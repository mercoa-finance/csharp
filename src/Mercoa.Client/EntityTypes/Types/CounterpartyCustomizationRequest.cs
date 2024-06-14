using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class CounterpartyCustomizationRequest
{
    [JsonPropertyName("counterpartyId")]
    public string CounterpartyId { get; init; }

    /// <summary>
    /// The ID the counterparty has assigned to this account.
    /// </summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; init; }
}
