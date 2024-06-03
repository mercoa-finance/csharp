using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class CardRequest
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

    [JsonPropertyName("token")]
    public string Token { get; init; }

    /// <summary>
    /// If true, this payment method will be set as the default source. Only one payment method can be set as the default source. If another payment method is already set as the default source, it will be unset.
    /// </summary>
    [JsonPropertyName("defaultSource")]
    public bool? DefaultSource { get; init; }

    /// <summary>
    /// If true, this payment method will be set as the default destination. Only one payment method can be set as the default destination. If another payment method is already set as the default destination, it will be unset.
    /// </summary>
    [JsonPropertyName("defaultDestination")]
    public bool? DefaultDestination { get; init; }
}
