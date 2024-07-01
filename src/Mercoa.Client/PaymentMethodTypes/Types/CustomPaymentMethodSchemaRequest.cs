using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class CustomPaymentMethodSchemaRequest
{
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// This payment method can be used as a payment source for an invoice
    /// </summary>
    [JsonPropertyName("isSource")]
    public bool IsSource { get; init; }

    /// <summary>
    /// This payment method can be used as a payment destination for an invoice
    /// </summary>
    [JsonPropertyName("isDestination")]
    public bool IsDestination { get; init; }

    /// <summary>
    /// List of currencies that this payment method supports. If not provided, the payment method will support only USD.
    /// </summary>
    [JsonPropertyName("supportedCurrencies")]
    public IEnumerable<CurrencyCode>? SupportedCurrencies { get; init; }

    [JsonPropertyName("fields")]
    public IEnumerable<CustomPaymentMethodSchemaField> Fields { get; init; }

    /// <summary>
    /// Estimated time in days for this payment method to process a payments. Set as 0 for same-day payment methods, -1 for unknown processing time.
    /// </summary>
    [JsonPropertyName("estimatedProcessingTime")]
    public int? EstimatedProcessingTime { get; init; }

    [JsonPropertyName("fees")]
    public CustomPaymentMethodSchemaFee? Fees { get; init; }
}
