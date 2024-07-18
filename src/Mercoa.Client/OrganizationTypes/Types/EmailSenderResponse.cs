using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record EmailSenderResponse
{
    [JsonPropertyName("provider")]
    public required EmailSenderProvider Provider { get; init; }

    [JsonPropertyName("fromEmail")]
    public required string FromEmail { get; init; }

    [JsonPropertyName("fromName")]
    public required string FromName { get; init; }

    [JsonPropertyName("hasApiKey")]
    public required bool HasApiKey { get; init; }
}
