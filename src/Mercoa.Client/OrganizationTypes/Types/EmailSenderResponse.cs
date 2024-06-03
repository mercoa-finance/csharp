using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class EmailSenderResponse
{
    [JsonPropertyName("provider")]
    public EmailSenderProvider Provider { get; init; }

    [JsonPropertyName("fromEmail")]
    public string FromEmail { get; init; }

    [JsonPropertyName("fromName")]
    public string FromName { get; init; }

    [JsonPropertyName("hasApiKey")]
    public bool HasApiKey { get; init; }
}
