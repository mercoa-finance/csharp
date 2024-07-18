using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record InvoiceStatusChangedWebhook
{
    [JsonPropertyName("newStatus")]
    public required string NewStatus { get; init; }

    [JsonPropertyName("previousStatus")]
    public required string PreviousStatus { get; init; }

    [JsonPropertyName("eventType")]
    public required string EventType { get; init; }

    [JsonPropertyName("invoice")]
    public required InvoiceResponse Invoice { get; init; }

    /// <summary>
    /// User who initiated the change.
    /// </summary>
    [JsonPropertyName("user")]
    public EntityUserResponse? User { get; init; }
}
