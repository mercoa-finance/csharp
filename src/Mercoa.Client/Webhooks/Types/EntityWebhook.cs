using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityWebhook
{
    [JsonPropertyName("eventType")]
    public required string EventType { get; set; }

    [JsonPropertyName("entity")]
    public required EntityResponse Entity { get; set; }

    /// <summary>
    /// User who initiated the change.
    /// </summary>
    [JsonPropertyName("user")]
    public EntityUserResponse? User { get; set; }
}
