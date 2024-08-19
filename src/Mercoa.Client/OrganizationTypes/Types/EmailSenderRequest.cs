using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EmailSenderRequest
{
    [JsonPropertyName("provider")]
    public required EmailSenderProvider Provider { get; set; }

    [JsonPropertyName("fromEmail")]
    public required string FromEmail { get; set; }

    [JsonPropertyName("fromName")]
    public required string FromName { get; set; }

    [JsonPropertyName("apiKey")]
    public string? ApiKey { get; set; }
}
