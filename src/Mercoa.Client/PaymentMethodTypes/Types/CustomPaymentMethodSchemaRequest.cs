using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record CustomPaymentMethodSchemaRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// This payment method can be used as a payment source for an invoice
    /// </summary>
    [JsonPropertyName("isSource")]
    public required bool IsSource { get; init; }

    /// <summary>
    /// This payment method can be used as a payment destination for an invoice
    /// </summary>
    [JsonPropertyName("isDestination")]
    public required bool IsDestination { get; init; }

    /// <summary>
    /// List of currencies that this payment method supports. If not provided, the payment method will support only USD.
    /// </summary>
    [JsonPropertyName("supportedCurrencies")]
    public IEnumerable<CurrencyCode>? SupportedCurrencies { get; init; }

    [JsonPropertyName("fields")]
    public IEnumerable<CustomPaymentMethodSchemaField> Fields { get; init; } =
        new List<CustomPaymentMethodSchemaField>();

    /// <summary>
    /// Estimated time in days for this payment method to process a payments. Set as 0 for same-day payment methods, -1 for unknown processing time.
    /// </summary>
    [JsonPropertyName("estimatedProcessingTime")]
    public int? EstimatedProcessingTime { get; init; }

    /// <summary>
    /// The maximum amount that can be transferred from this payment method in a single transaction.
    /// </summary>
    [JsonPropertyName("maxAmount")]
    public double? MaxAmount { get; init; }

    /// <summary>
    /// The minimum amount that can be transferred from this payment method in a single transaction. Default is 1.
    /// </summary>
    [JsonPropertyName("minAmount")]
    public double? MinAmount { get; init; }

    [JsonPropertyName("fees")]
    public CustomPaymentMethodSchemaFee? Fees { get; init; }
}
