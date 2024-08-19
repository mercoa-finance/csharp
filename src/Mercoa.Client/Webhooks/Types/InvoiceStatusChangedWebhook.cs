using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceStatusChangedWebhook
{
    [JsonPropertyName("newStatus")]
    public required string NewStatus { get; set; }

    [JsonPropertyName("previousStatus")]
    public required string PreviousStatus { get; set; }

    [JsonPropertyName("eventType")]
    public required string EventType { get; set; }

    [JsonPropertyName("invoice")]
    public required InvoiceResponse Invoice { get; set; }

    /// <summary>
    /// User who initiated the change.
    /// </summary>
    [JsonPropertyName("user")]
    public EntityUserResponse? User { get; set; }
}
