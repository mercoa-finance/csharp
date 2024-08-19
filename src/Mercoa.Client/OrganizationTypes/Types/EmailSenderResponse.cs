using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EmailSenderResponse
{
    [JsonPropertyName("provider")]
    public required EmailSenderProvider Provider { get; set; }

    [JsonPropertyName("fromEmail")]
    public required string FromEmail { get; set; }

    [JsonPropertyName("fromName")]
    public required string FromName { get; set; }

    [JsonPropertyName("hasApiKey")]
    public required bool HasApiKey { get; set; }
}
