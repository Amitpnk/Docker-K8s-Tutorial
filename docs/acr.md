<!-- ## ACR Login
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
  --attach-acr acrweatherdemo -->
