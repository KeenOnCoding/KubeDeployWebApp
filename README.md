# KubeDeployWebApp
Kubernetes deployment with MS SQL migrations MVC Authentication Docker Ingress NodePort 
Kubernetes
kubectl get all
kubectl get nodes
kubectl get pods
kubectl get pods --watch
kubectl get deployments
kubectl get pvc
kubectl get storageclass

kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/controller-v1.5.1/deploy/static/provider/aws/deploy.yaml

kubectl delete deployment app-depl
docker build -t keenoncoding/kubedeployappservice .
docker push keenoncoding/kubedeployappservice
kubectl apply -f app-depl

kubectl rollout restart deployment app-depl


http://localhost:31763/



