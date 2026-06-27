using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Atya.Governance.CodeQuality.Benchmarks;

public static class Program
{
    public static void Main(string[] args)
    {
        _ = args;
        BenchmarkRunner.Run<TemplateBenchmarks>();
    }
}

[MemoryDiagnoser]
public class TemplateBenchmarks
{
    private readonly string _value = "Atya.Governance.CodeQuality";

    [Benchmark]
    public int ReadStarterValueLength()
    {
        return _value.Length;
    }
}
