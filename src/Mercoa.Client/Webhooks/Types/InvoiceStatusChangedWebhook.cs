using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class InvoiceStatusChangedWebhook
{
    [JsonPropertyName("newStatus")]
    public string NewStatus { get; init; }

    [JsonPropertyName("previousStatus")]
    public string PreviousStatus { get; init; }

    [JsonPropertyName("eventType")]
    public string EventType { get; init; }

    [JsonPropertyName("invoice")]
    public InvoiceResponse Invoice { get; init; }
}
