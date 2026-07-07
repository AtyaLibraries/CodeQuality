using Atya.Governance.CodeQuality;

namespace Atya.Governance.CodeQuality.UnitTests;

public sealed class PackageContentTests
{
    [Fact]
    public void BuildTransitiveAssetsExist()
    {
        string projectDirectory = AppContext.BaseDirectory;
        string buildTransitivePath = Path.GetFullPath(Path.Combine(
            projectDirectory,
            "..",
            "..",
            "..",
            "..",
            "..",
            "src",
            "CodeQuality",
            CodeQualityPackageAssets.BuildTransitiveDirectoryName));

        foreach (string fileName in CodeQualityPackageAssets.BuildTransitiveAssetFileNames)
        {
            File.Exists(Path.Combine(buildTransitivePath, fileName)).Should().BeTrue();
        }
    }
}
