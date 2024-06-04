using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class PaymentMethodBaseResponse
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// Indicates whether this payment method is the default source for the entity
    /// </summary>
    [JsonPropertyName("isDefaultSource")]
    public bool IsDefaultSource { get; init; }

    /// <summary>
    /// Indicates whether this payment method is the default destination for the entity
    /// </summary>
    [JsonPropertyName("isDefaultDestination")]
    public bool IsDefaultDestination { get; init; }

    [JsonPropertyName("supportedCurrencies")]
    public IEnumerable<CurrencyCode> SupportedCurrencies { get; init; }

    /// <summary>
    /// ID for this payment method in the external accounting system (e.g Rutter or Codat)
    /// </summary>
    [JsonPropertyName("externalAccountingSystemId")]
    public string? ExternalAccountingSystemId { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }
}
