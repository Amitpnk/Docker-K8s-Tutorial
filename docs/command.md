docker build -t weather-service -f docker/Dockerfile .


docker run -p 5000:8080 weather-service


http://localhost:5000/swagger

http://localhost:5000/scalar/


kubectl apply -f k8s/weather-deployment.yaml
kubectl apply -f k8s/weather-service.yaml
kubectl apply -f k8s/weather-ingress.yaml
