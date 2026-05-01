using System;

namespace CodeQuality.Sample.Console.WrongStyleExamples;

// Intentionally wrong: uses BCL type names where C# keywords are preferred and var where it is disabled.
internal sealed class PredefinedTypesAndVarUsage
{
    public String FormatCount(Int32 count)
    {
        var label = "Count";
        String rendered = String.Concat(label, ": ", count.ToString());

        return rendered;
    }
}
