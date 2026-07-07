// <copyright file="CodeQualityPackageAssets.cs" company="Atya">
// Copyright (c) Atya. All rights reserved.
// </copyright>

namespace Atya.Governance.CodeQuality;

/// <summary>
/// Describes the static assets included in the code quality package.
/// </summary>
public static class CodeQualityPackageAssets
{
    private static readonly string[] AssetFileNames =
    [
        "Atya.Governance.CodeQuality.props",
        "Atya.Governance.CodeQuality.globalconfig",
        "stylecop.json",
    ];

    /// <summary>
    /// Gets the package path that contains transitive build assets.
    /// </summary>
    public static string BuildTransitiveDirectoryName => "buildTransitive";

    /// <summary>
    /// Gets the expected transitive build asset file names.
    /// </summary>
    public static IReadOnlyList<string> BuildTransitiveAssetFileNames => AssetFileNames;
}
