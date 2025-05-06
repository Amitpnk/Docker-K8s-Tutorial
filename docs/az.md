az login

az group create --name rg-docker-k8s --location eastus


az acr create --resource-group rg-docker-k8s --name acrweatherdemo  --sku Basic --admin-enabled true


## ACR Login
az acr login --name acrweatherdemo

## Build Docker Image

docker build -t weather-service:latest -f docker/Dockerfile .

## Tag the Image for ACR
docker tag weather-service:latest acrweatherdemo.azurecr.io/weather-service:latest

## Push to ACR
docker push acrweatherdemo.azurecr.io/weather-service:latest


az acr update --name acrweatherdemo --admin-enabled true
docker push acrweatherdemo.azurecr.io/weather-service:latest


Fix: Register the Resource Provider
 
az provider register --namespace Microsoft.ContainerService
Then, wait 1–2 minutes and verify it’s registered:
 
az provider show --namespace Microsoft.ContainerService --query "registrationState"
You should see:
 
"Registered"

## Create AKS Cluster
az aks create ^
  --resource-group rg-docker-k8s ^
  --name aks-weatherdemo ^
  --node-count 1 ^
  --enable-addons monitoring ^
  --generate-ssh-keys ^
  --location eastus

# Attach ACR to AKS (so it can pull private images)
az aks update ^
  --resource-group rg-docker-k8s ^
  --name aks-weatherdemo ^
  --attach-acr acrweatherdemo


## Get AKS Credentials for kubectl
az aks get-credentials --resource-group rg-docker-k8s --name aks-weatherdemo


## Verify Access to Cluster
kubectl get nodes

## Apply Kubernetes Manifests
kubectl apply -f k8s/weather-deployment.yaml
kubectl apply -f k8s/weather-service.yaml
kubectl apply -f k8s/weather-ingress.yaml

##  Check Pod Status
kubectl get pods
Make sure the pods are running. If not, describe the pod:

kubectl describe pod <pod-name>


## Access Your Service
If you're using a LoadBalancer service, get the external IP:
kubectl get service weather-service

If using an Ingress, make sure you have an Ingress controller (like NGINX) installed and get the IP from:
kubectl get ingress

## Check Services
kubectl get svc

Access the App
Use the EXTERNAL-IP from above

Access: http://<EXTERNAL-IP>/api/WeatherForecast/GetWeatherForecast


kubectl get pods --all-namespaces
kubectl logs weather-service-5895755b84-8dt8f