# CodeQuality

Reusable NuGet package for centralized code-quality policy across Atya repositories.

## Purpose

This package provides one shared place for analyzer and coding-style configuration. Projects that reference it receive the same .NET analyzer settings, StyleCop settings, and selected StyleCop analyzer assemblies.

The package is intentionally explicit: it enables the analyzer rules documented by this policy, but it does not force broad `AnalysisMode` presets or XML documentation generation on consuming projects.

## Contents

- `buildTransitive/Atya.Governance.CodeQuality.props`
  - Enables SDK analyzers and wires shared config files into consuming projects.
- `buildTransitive/Atya.Governance.CodeQuality.globalconfig`
  - Shared analyzer severities, naming rules, and code-style policy.
- `buildTransitive/stylecop.json`
  - StyleCop-specific behavior, such as using placement and ordering behavior.
- `analyzers/dotnet/cs/*.dll`
  - Repacked StyleCop analyzer assemblies.
- `docs/CODING_STYLE.md`
  - Shared coding-style documentation.

## Usage

Reference the package from a consuming project:

```xml
<PackageReference Include="Atya.Governance.CodeQuality" Version="1.0.0" PrivateAssets="all" />
```

The package uses `buildTransitive`, so the analyzer policy flows automatically into projects that reference it.

Use the shared repository `.editorconfig` alongside this package for formatting/editor behavior. If the same analyzer key is defined in both `.editorconfig` and this package's global analyzer config, the repository `.editorconfig` wins.

## Policy scope

The package currently enforces:

- selected .NET analyzer/code-style rules, such as `nameof(...)`, unnecessary `this.`, predefined type keywords, readonly fields, and unused suppressions;
- selected StyleCop rules for using placement/order, member/modifier ordering, braces/blank lines, accessibility modifiers, and naming;
- private/internal field prefixes (`_camelCase`, `s_camelCase`) through .NET naming rules.

The package does not enforce StyleCop XML documentation/file-header rules by default.

## Local development

When testing the package from this repository with a `ProjectReference` or a direct `.props` import, remember that this is not the same as consuming the packed NuGet package. A project reference does not automatically expose the package's `analyzers/dotnet/cs` assets.

For local analyzer demos, either:

- reference the packed `.nupkg`, or
- add `StyleCop.Analyzers` directly to the sample project.

The shared `stylecop.json` file should still come from `buildTransitive/Atya.Governance.CodeQuality.props`.

To compile the intentionally wrong sample files and inspect diagnostics:

```bash
dotnet build samples/CodeQuality.Sample.Console/CodeQuality.Sample.Console.csproj -p:EnableWrongStyleExamples=true
```

## Pack

```bash
dotnet pack -c Release
```
