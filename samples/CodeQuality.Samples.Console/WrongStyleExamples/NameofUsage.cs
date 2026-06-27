using System;

namespace CodeQuality.Sample.Console.WrongStyleExamples;

// Intentionally wrong: string literals are used where nameof(...) should be used.
internal sealed class NameofUsage
{
    public void ThrowWhenMissing(string customerId)
    {
        if (customerId is null)
        {
            throw new ArgumentNullException("customerId");
        }
    }
}
