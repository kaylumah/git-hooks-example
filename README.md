# git-hooks-example

This repository contains the code used in an experiment to use C# in my githooks.

```sh
mkdir git-hooks-example
cd git-hooks-example
git init
dotnet new gitignore
dotnet new tool-manifest
dotnet tool install dotnet-script
dotnet tool install dotnet-format
mkdir .githooks
```

```sh
find .git/hooks -type f -exec rm {} \;
find .githooks -type f -exec chmod +x {} \;
find .githooks -type f -exec ln -sf ../../{} .git/hooks/ \;
```
