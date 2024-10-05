using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CounterpartyEventWebhook
{
    [JsonPropertyName("eventType")]
    public required string EventType { get; set; }

    /// <summary>
    /// The ID of the entity that owns the counterparty relationship
    /// </summary>
    [JsonPropertyName("entityId")]
    public required string EntityId { get; set; }

    /// <summary>
    /// The ID of the counterparty
    /// </summary>
    [JsonPropertyName("counterpartyId")]
    public required string CounterpartyId { get; set; }
}
