using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CardResponse
{
    [JsonPropertyName("cardType")]
    public required CardType CardType { get; set; }

    [JsonPropertyName("cardBrand")]
    public required CardBrand CardBrand { get; set; }

    [JsonPropertyName("lastFour")]
    public required string LastFour { get; set; }

    [JsonPropertyName("expMonth")]
    public required string ExpMonth { get; set; }

    [JsonPropertyName("expYear")]
    public required string ExpYear { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Indicates whether this payment method is the default source for the entity
    /// </summary>
    [JsonPropertyName("isDefaultSource")]
    public required bool IsDefaultSource { get; set; }

    /// <summary>
    /// Indicates whether this payment method is the default destination for the entity
    /// </summary>
    [JsonPropertyName("isDefaultDestination")]
    public required bool IsDefaultDestination { get; set; }

    [JsonPropertyName("supportedCurrencies")]
    public IEnumerable<CurrencyCode> SupportedCurrencies { get; set; } = new List<CurrencyCode>();

    /// <summary>
    /// ID for this payment method in the external accounting system (e.g Rutter or Codat)
    /// </summary>
    [JsonPropertyName("externalAccountingSystemId")]
    public string? ExternalAccountingSystemId { get; set; }

    /// <summary>
    /// Frozen payment methods cannot be used for payments, but will still be returned in API responses.
    /// </summary>
    [JsonPropertyName("frozen")]
    public required bool Frozen { get; set; }

    /// <summary>
    /// Metadata associated with this payment method.
    /// </summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }
}
