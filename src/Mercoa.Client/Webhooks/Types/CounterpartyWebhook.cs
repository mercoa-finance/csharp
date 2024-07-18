using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record CounterpartyWebhook
{
    [JsonPropertyName("eventType")]
    public required string EventType { get; init; }

    [JsonPropertyName("payeeId")]
    public IEnumerable<string> PayeeId { get; init; } = new List<string>();

    [JsonPropertyName("payorId")]
    public IEnumerable<string> PayorId { get; init; } = new List<string>();

    /// <summary>
    /// User who initiated the change.
    /// </summary>
    [JsonPropertyName("user")]
    public EntityUserResponse? User { get; init; }
}
