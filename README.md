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

## Publishing

Packages are published to nuget.org automatically when changes are merged into `master`.

Configure a GitHub Actions repository secret named `NUGET_API_KEY` with a nuget.org API key that has permission to push `Atya.Governance.CodeQuality`.

NuGet package versions are immutable. Update the package `<Version>` in `src/CodeQuality/CodeQuality.csproj` before merging a release change, otherwise nuget.org will reject the already-published version.

## Layout

- `src/CodeQuality` - NuGet package project and packaged analyzer configuration.
- `samples/CodeQuality.Sample.Console` - sample consumer project.
- `src/CodeQuality/CODING_STYLE.md` - policy reference.
- `LOCAL_NUGET.md` - local feed workflow for pre-publish testing.
