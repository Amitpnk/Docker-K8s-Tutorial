# Docker-K8s-Tutorial 🚀

A hands-on tutorial repository to help you containerize .NET microservices, deploy them to Kubernetes, and move workloads to Azure Kubernetes Service (AKS) using Azure Container Registry (ACR). This project demonstrates how to automate deployments using Azure DevOps and GitHub Actions, enabling seamless CI/CD workflows for modern cloud-native applications.

---

## What’s Inside

- ✅ .NET 9 Microservices (ASP.NET Core Web API)
- 🐳 Dockerfiles and Docker Compose setup
- ☸️ Kubernetes manifests for local or cloud clusters
- 🔐 Secure deployment to AKS using ACR
- 🔁 CI/CD automation via:
  - Azure DevOps Pipelines
  - GitHub Actions
- 📚 Detailed walkthroughs and step-by-step guides

---

## 📂 Repository Structure

| Folder          | Description                                      |
|-----------------|--------------------------------------------------|
| `src/`          | .NET Core microservices                          |
| `docker/`       | Dockerfiles and docker-compose config            |
| `k8s/`          | Kubernetes deployment YAMLs                      |
| `aks/`          | Scripts to deploy to Azure Kubernetes Service    |
| `ci-cd/`        | CI/CD pipelines for Azure DevOps & GitHub Actions |
| `docs/`         | Tutorial guides and documentation                |

---

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- [Docker](https://www.docker.com/products/docker-desktop)
- [kubectl](https://kubernetes.io/docs/tasks/tools/)
- [Azure CLI](https://learn.microsoft.com/en-us/cli/azure/install-azure-cli)
- [GitHub CLI](https://cli.github.com/) (optional)
- Azure DevOps or GitHub account

---

## 🧪 Tutorials

- [x] Step 1: Build and Run Microservices with Docker
- [x] Step 2: Deploy to Kubernetes (Minikube/Local)
- [x] Step 3: Push images to ACR
- [x] Step 4: Deploy to AKS
- [x] Step 5: Setup CI/CD with Azure DevOps
- [x] Step 6: Setup CI/CD with GitHub Actions

> 📖 Detailed documentation is in the [`docs/`](./docs) folder.

---

## 📄 License

This project is licensed under the MIT License.
