# Atya Governance CodeQuality

Reusable NuGet package for centralized .NET analyzer, StyleCop, and C# style policy across Atya repositories.

## Usage

```xml
<PackageReference Include="Atya.Governance.CodeQuality" Version="1.0.0" PrivateAssets="all" />
```

Use the repository `.editorconfig` with the package for formatting/editor behavior. The NuGet package carries the build-time analyzer policy through `buildTransitive`.

## Build

```powershell
dotnet restore .\CodeQuality.sln --verbosity minimal
dotnet build .\CodeQuality.sln --configuration Release --no-restore --verbosity minimal
dotnet pack .\src\CodeQuality\CodeQuality.csproj --configuration Release --no-build --verbosity minimal
```

## Layout

- `src/CodeQuality` - NuGet package project and packaged analyzer configuration.
- `samples/CodeQuality.Sample.Console` - sample consumer project.
- `src/CodeQuality/CODING_STYLE.md` - policy reference.
- `LOCAL_NUGET.md` - local feed workflow for pre-publish testing.
