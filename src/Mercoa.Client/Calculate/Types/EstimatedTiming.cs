using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EstimatedTiming
{
    /// <summary>
    /// Date the payment is scheduled to be deducted from the payer's account. Use this field if the payment has not yet been deducted.
    /// </summary>
    [JsonPropertyName("estimatedDeductionDate")]
    public DateTime? EstimatedDeductionDate { get; set; }

    /// <summary>
    /// Date the payment was processed. Use this field if the payment has already been deducted.
    /// </summary>
    [JsonPropertyName("processedAt")]
    public DateTime? ProcessedAt { get; set; }

    /// <summary>
    /// ID of payment source.
    /// </summary>
    [JsonPropertyName("paymentSourceId")]
    public required string PaymentSourceId { get; set; }

    /// <summary>
    /// ID of payment destination.
    /// </summary>
    [JsonPropertyName("paymentDestinationId")]
    public required string PaymentDestinationId { get; set; }

    /// <summary>
    /// Options for the payment destination. Depending on the payment destination, this may include things such as check delivery method.
    /// </summary>
    [JsonPropertyName("paymentDestinationOptions")]
    public object? PaymentDestinationOptions { get; set; }
}
