namespace CodeQuality.Sample.Console.WrongStyleExamples
{
    using Microsoft.Win32;
    using System;

    // Intentionally wrong: using directives are inside the namespace and System is not first.
    internal sealed class UsingPlacementAndOrdering
    {
        public string BuildKeyName()
        {
            return Registry.CurrentUser.Name + DateTime.UtcNow.Year.ToString();
        }
    }
}
