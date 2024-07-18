using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record CounterpartyCustomizationRequest
{
    [JsonPropertyName("counterpartyId")]
    public required string CounterpartyId { get; init; }

    /// <summary>
    /// The list of accounts the entity has with the counterparty.
    /// </summary>
    [JsonPropertyName("accounts")]
    public IEnumerable<CounterpartyCustomizationAccount>? Accounts { get; init; }
}
