using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class PaymentMethodWebhook
{
    [JsonPropertyName("eventType")]
    public string EventType { get; init; }

    [JsonPropertyName("entityId")]
    public string EntityId { get; init; }

    [JsonPropertyName("paymentMethod")]
    public PaymentMethodResponse PaymentMethod { get; init; }

    [JsonPropertyName("entity")]
    public EntityResponse Entity { get; init; }
}
