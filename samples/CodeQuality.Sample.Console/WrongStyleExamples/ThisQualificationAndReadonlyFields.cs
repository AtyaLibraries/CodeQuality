namespace CodeQuality.Sample.Console.WrongStyleExamples;

// Intentionally wrong: unnecessary this. qualification and fields that should be readonly.
internal sealed class ThisQualificationAndReadonlyFields
{
    private string _message;
    private int _retryCount;

    public ThisQualificationAndReadonlyFields(string message, int retryCount)
    {
        this._message = message;
        this._retryCount = retryCount;
    }

    public string Build()
    {
        return this._message.Trim() + ":" + this._retryCount.ToString();
    }
}
