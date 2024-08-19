namespace Mercoa.Client;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class BadRequest(string body) : MercoaApiException("BadRequest", 400, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new string Body { get; } = body;
}
