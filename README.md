# Play.Common

Common libraries used by Play microservices

## Create and publish package

```
version="1.0.8"
owner="samsonprojects"
gh_pat="[PAT HERE]"

dotnet pack src/Play.Common/ --configuration Release -p:PackageVersion=$version -p:RepositoryUrl=https://github.com/$owner/Play.Common -o ../packages


dotnet nuget push ../packages/Play.Common.$version.nupkg --api-key $gh_pat --source "github"

```
