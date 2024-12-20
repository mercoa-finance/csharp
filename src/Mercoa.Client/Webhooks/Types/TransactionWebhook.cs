using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record TransactionWebhook
{
    [JsonPropertyName("eventType")]
    public required string EventType { get; set; }

    [JsonPropertyName("transaction")]
    public required object Transaction { get; set; }
}
