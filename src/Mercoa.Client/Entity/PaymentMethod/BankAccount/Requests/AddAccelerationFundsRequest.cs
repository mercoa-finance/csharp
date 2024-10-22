using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.Entity.PaymentMethod;

public record AddAccelerationFundsRequest
{
    /// <summary>
    /// The amount of the acceleration funds to add. If the entered amount has more decimal places than the currency supports, trailing decimals will be truncated.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; set; }

    /// <summary>
    /// The currency of the acceleration funds to add.
    /// </summary>
    [JsonPropertyName("currency")]
    public required CurrencyCode Currency { get; set; }
}
