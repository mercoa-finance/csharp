using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CounterpartyWebhook
{
    [JsonPropertyName("eventType")]
    public required string EventType { get; set; }

    [JsonPropertyName("payeeId")]
    public IEnumerable<string> PayeeId { get; set; } = new List<string>();

    [JsonPropertyName("payorId")]
    public IEnumerable<string> PayorId { get; set; } = new List<string>();

    /// <summary>
    /// User who initiated the change.
    /// </summary>
    [JsonPropertyName("user")]
    public EntityUserResponse? User { get; set; }
}
