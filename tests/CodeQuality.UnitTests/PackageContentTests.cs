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
            "buildTransitive"));

        File.Exists(Path.Combine(buildTransitivePath, "Atya.Governance.CodeQuality.props")).Should().BeTrue();
        File.Exists(Path.Combine(buildTransitivePath, "Atya.Governance.CodeQuality.globalconfig")).Should().BeTrue();
        File.Exists(Path.Combine(buildTransitivePath, "stylecop.json")).Should().BeTrue();
    }
}
