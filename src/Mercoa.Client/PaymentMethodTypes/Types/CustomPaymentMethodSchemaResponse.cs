using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record CustomPaymentMethodSchemaResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

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
    /// List of currencies that this payment method supports.
    /// </summary>
    [JsonPropertyName("supportedCurrencies")]
    public IEnumerable<CurrencyCode> SupportedCurrencies { get; init; } = new List<CurrencyCode>();

    [JsonPropertyName("fields")]
    public IEnumerable<CustomPaymentMethodSchemaField> Fields { get; init; } =
        new List<CustomPaymentMethodSchemaField>();

    /// <summary>
    /// Estimated time in days for this payment method to process a payments. 0 is an same-day payment methods, -1 is unknown processing time.
    /// </summary>
    [JsonPropertyName("estimatedProcessingTime")]
    public required int EstimatedProcessingTime { get; init; }

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

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; init; }
}
