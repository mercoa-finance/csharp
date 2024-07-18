using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record EntityWebhook
{
    [JsonPropertyName("eventType")]
    public required string EventType { get; init; }

    [JsonPropertyName("entity")]
    public required EntityResponse Entity { get; init; }

    /// <summary>
    /// User who initiated the change.
    /// </summary>
    [JsonPropertyName("user")]
    public EntityUserResponse? User { get; init; }
}
