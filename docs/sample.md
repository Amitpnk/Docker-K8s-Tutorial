# 🚀 Docker-K8s-Tutorial

This repository demonstrates how to:

- Containerize a .NET microservice using **Docker**
- Deploy it to **Kubernetes (K8s)** and **Azure Kubernetes Service (AKS)**
- Push container images to **Azure Container Registry (ACR)**
- Automate CI/CD with **GitHub Actions**

---

## 🗂️ Project Structure

```
Docker-K8s-Tutorial/
├── docker/
│ └── Dockerfile
├── src/
│ └── WeatherService/
│ ├── Controllers/
│ ├── Program.cs
├── k8s/
│ ├── weather-deployment.yaml
│ ├── weather-service.yaml
│ └── weather-ingress.yaml
├── .github/
│ └── workflows/
│ └── ci-cd.yaml 
├── docker-compose.yml (optional)
└── README.md
```


## 🐳 Docker Commands

### Build Docker image:

```bash
docker build -t weather-service:latest -f docker/Dockerfile .
docker run -p 5000:8080 weather-service
```

Then navigate to:

http://localhost:5000/swagger

http://localhost:5000/scalar


☸️ Kubernetes Deployment
```bash
kubectl apply -f k8s/weather-deployment.yaml
kubectl apply -f k8s/weather-service.yaml
kubectl apply -f k8s/weather-ingress.yaml 
```

🔁 CI/CD via GitHub Actions
This repo includes a GitHub Actions workflow to:

Build and push Docker image to ACR

Deploy to AKS using kubectl

Required Secrets:
AZURE_CREDENTIALS — Azure service principal credentials (JSON format)

ACR_NAME — Azure Container Registry name

ACR_USERNAME and ACR_PASSWORD — Credentials for ACR

AKS_RESOURCE_GROUP — Resource group of AKS

AKS_CLUSTER_NAME — Your AKS cluster name

See .github/workflows/ci-cd.yaml for full workflow details.

```
docker-compose up --build
```

🌐 Resources

Azure Container Registry (ACR)

Azure Kubernetes Service (AKS)

GitHub Actions for Azure

