using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class EmailSenderRequest
{
    [JsonPropertyName("provider")]
    public EmailSenderProvider Provider { get; init; }

    [JsonPropertyName("fromEmail")]
    public string FromEmail { get; init; }

    [JsonPropertyName("fromName")]
    public string FromName { get; init; }

    [JsonPropertyName("apiKey")]
    public string? ApiKey { get; init; }
}
