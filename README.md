# Play.Common

Common libraries used by Play microservices

## Create and publish package

```
version="1.0.6"
owner="samsonprojects"

dotnet pack src/Play.Common/ --configuration Release -p:PackageVersion=$version -p:RepositoryUrl=https://github.com/$owner/Play.Common -o ../packages
```
