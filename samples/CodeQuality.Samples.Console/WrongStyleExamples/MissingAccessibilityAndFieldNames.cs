namespace CodeQuality.Sample.Console.WrongStyleExamples;

// Intentionally wrong: missing accessibility, field prefixes, constant casing, method casing, and parameter casing.
class MissingAccessibilityAndFieldNames
{
    string customerName = "Ada";
    static int processedCount;
    public int public_counter;
    const string default_message = "Hello";

    void write_message(string UserName)
    {
        System.Console.WriteLine(default_message + ", " + UserName + " " + customerName + processedCount + public_counter);
    }
}
