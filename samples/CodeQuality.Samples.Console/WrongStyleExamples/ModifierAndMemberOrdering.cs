namespace CodeQuality.Sample.Console.WrongStyleExamples;

// Intentionally wrong: modifier order is not preferred and fields are not placed before methods.
internal sealed class ModifierAndMemberOrdering
{
    public string Build()
    {
        return CachedValue.ToString();
    }

    static internal readonly int CachedValue = 42;
}
