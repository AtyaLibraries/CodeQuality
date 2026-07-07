using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Atya.Governance.CodeQuality.Benchmarks;

/// <summary>
/// Runs the code quality benchmarks.
/// </summary>
public static class Program
{
    /// <summary>
    /// Starts the benchmark runner.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    public static void Main(string[] args)
    {
        _ = args;
        BenchmarkRunner.Run<TemplateBenchmarks>();
    }
}

/// <summary>
/// Benchmarks simple code quality helper access.
/// </summary>
[MemoryDiagnoser]
public class TemplateBenchmarks
{
    private readonly string _value = "Atya.Governance.CodeQuality";

    /// <summary>
    /// Reads the length of a representative value.
    /// </summary>
    /// <returns>The value length.</returns>
    [Benchmark]
    public int ReadStarterValueLength()
    {
        return _value.Length;
    }
}
