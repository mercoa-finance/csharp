using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record CalculateFeesRequest
{
    /// <summary>
    /// Total amount in major units. If the entered amount has more decimal places than the currency supports, trailing decimals will be truncated.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// Currency code for the amount. Defaults to USD.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? Currency { get; init; }

    /// <summary>
    /// ID of payment source.
    /// </summary>
    [JsonPropertyName("paymentSourceId")]
    public required string PaymentSourceId { get; init; }

    /// <summary>
    /// ID of payment destination.
    /// </summary>
    [JsonPropertyName("paymentDestinationId")]
    public required string PaymentDestinationId { get; init; }

    /// <summary>
    /// Options for the payment destination. Depending on the payment destination, this may include things such as check delivery method.
    /// </summary>
    [JsonPropertyName("paymentDestinationOptions")]
    public object? PaymentDestinationOptions { get; init; }
}
