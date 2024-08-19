using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceWebhook
{
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
