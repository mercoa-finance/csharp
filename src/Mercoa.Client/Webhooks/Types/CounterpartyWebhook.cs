using System.Text.Json.Serialization;
using Mercoa.Client;

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

    /// <summary>
    /// User who initiated the change.
    /// </summary>
    [JsonPropertyName("user")]
    public EntityUserResponse? User { get; init; }
}
