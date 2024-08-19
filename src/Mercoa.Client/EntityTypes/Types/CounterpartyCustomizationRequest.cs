using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CounterpartyCustomizationRequest
{
    [JsonPropertyName("counterpartyId")]
    public required string CounterpartyId { get; set; }

    /// <summary>
    /// The list of accounts the entity has with the counterparty.
    /// </summary>
    [JsonPropertyName("accounts")]
    public IEnumerable<CounterpartyCustomizationAccount>? Accounts { get; set; }
}
