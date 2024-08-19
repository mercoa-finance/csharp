using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record PaymentMethodWebhook
{
    [JsonPropertyName("eventType")]
    public required string EventType { get; set; }

    [JsonPropertyName("entityId")]
    public required string EntityId { get; set; }

    [JsonPropertyName("paymentMethod")]
    public required object PaymentMethod { get; set; }

    [JsonPropertyName("entity")]
    public required EntityResponse Entity { get; set; }

    /// <summary>
    /// User who initiated the change.
    /// </summary>
    [JsonPropertyName("user")]
    public EntityUserResponse? User { get; set; }
}
