using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class InvoiceWebhook
{
    [JsonPropertyName("eventType")]
    public string EventType { get; init; }

    [JsonPropertyName("invoice")]
    public InvoiceResponse Invoice { get; init; }
}
