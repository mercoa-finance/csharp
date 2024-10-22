using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.Entity.PaymentMethod;

public record RemoveAccelerationFundsRequest
{
    /// <summary>
    /// The amount of the acceleration funds to remove. If the entered amount has more decimal places than the currency supports, trailing decimals will be truncated.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; set; }

    /// <summary>
    /// The currency of the acceleration funds to remove.
    /// </summary>
    [JsonPropertyName("currency")]
    public required CurrencyCode Currency { get; set; }
}
