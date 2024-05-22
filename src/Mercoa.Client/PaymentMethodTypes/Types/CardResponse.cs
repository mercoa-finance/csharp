using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class CardResponse
{
    [JsonPropertyName("cardType")]
    public CardType CardType { get; init; }

    [JsonPropertyName("cardBrand")]
    public CardBrand CardBrand { get; init; }

    [JsonPropertyName("lastFour")]
    public string LastFour { get; init; }

    [JsonPropertyName("expMonth")]
    public string ExpMonth { get; init; }

    [JsonPropertyName("expYear")]
    public string ExpYear { get; init; }

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
    public List<CurrencyCode> SupportedCurrencies { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }
}
