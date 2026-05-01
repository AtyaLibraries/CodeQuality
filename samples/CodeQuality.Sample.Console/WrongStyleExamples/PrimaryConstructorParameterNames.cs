namespace CodeQuality.Sample.Console.WrongStyleExamples;

// Intentionally wrong: primary constructor parameters should be camelCase without prefixes.
internal sealed class PrimaryConstructorParameterNames(string _displayName, int ItemCount)
{
    public string DisplayName => _displayName;

    public int Count => ItemCount;
}
