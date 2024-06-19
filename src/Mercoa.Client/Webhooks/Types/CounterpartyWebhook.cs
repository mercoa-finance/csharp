using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class CounterpartyWebhook
{
    [JsonPropertyName("eventType")]
    public string EventType { get; init; }

    [JsonPropertyName("payeeId")]
    public string PayeeId { get; init; }

    [JsonPropertyName("payorId")]
    public string PayorId { get; init; }
}
