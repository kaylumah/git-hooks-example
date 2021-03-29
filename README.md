# git-hooks-example

This repository contains the source code for my article "Using C# code in your git hooks" which you can find [here](https://kaylumah.nl/2019/09/07/using-csharp-code-your-git-hooks.html).
If you have any questions or comments about the repo or the blog, feel free to reach out over on twitter [@kaylumah](https://twitter.com/kaylumah).

![Kaylumah Logo](logo.svg)

---

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
