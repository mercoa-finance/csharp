using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CustomPaymentMethodSchemaResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This payment method can be used as a payment source for an invoice
    /// </summary>
    [JsonPropertyName("isSource")]
    public required bool IsSource { get; set; }

    /// <summary>
    /// This payment method can be used as a payment destination for an invoice
    /// </summary>
    [JsonPropertyName("isDestination")]
    public required bool IsDestination { get; set; }

    /// <summary>
    /// List of currencies that this payment method supports.
    /// </summary>
    [JsonPropertyName("supportedCurrencies")]
    public IEnumerable<CurrencyCode> SupportedCurrencies { get; set; } = new List<CurrencyCode>();

    [JsonPropertyName("fields")]
    public IEnumerable<CustomPaymentMethodSchemaField> Fields { get; set; } =
        new List<CustomPaymentMethodSchemaField>();

    /// <summary>
    /// Estimated time in days for this payment method to process a payments. 0 is an same-day payment methods, -1 is unknown processing time.
    /// </summary>
    [JsonPropertyName("estimatedProcessingTime")]
    public required int EstimatedProcessingTime { get; set; }

    /// <summary>
    /// The maximum amount that can be transferred from this payment method in a single transaction.
    /// </summary>
    [JsonPropertyName("maxAmount")]
    public double? MaxAmount { get; set; }

    /// <summary>
    /// The minimum amount that can be transferred from this payment method in a single transaction. Default is 1.
    /// </summary>
    [JsonPropertyName("minAmount")]
    public double? MinAmount { get; set; }

    [JsonPropertyName("fees")]
    public CustomPaymentMethodSchemaFee? Fees { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }
}
