
GitHub CLI installed and authenticated: gh auth login

Docker installed and running.

You are logged into GHCR:

```
echo "<GITHUB_PAT>" | docker login ghcr.io -u <USERNAME> --password-stdin
```
Replace <GITHUB_PAT> with a GitHub Personal Access Token (PAT) with write:packages, read:packages, and delete:packages scopes.


```
docker build -t ghcr.io/amitpnk/weather-service:latest -f docker/Dockerfile .

docker push ghcr.io/amitpnk/weather-service:latest
```

```gh api \
  -X PATCH \
  -H "Accept: application/vnd.github+json" \
  /user/packages/container/amitpnk/visibility \
  -f visibility=public
```