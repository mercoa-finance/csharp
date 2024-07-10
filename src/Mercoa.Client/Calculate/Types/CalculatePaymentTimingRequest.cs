using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class CalculatePaymentTimingRequest
{
    /// <summary>
    /// Date the payment is scheduled to be deducted from the payer's account. Use this field if the payment has not yet been deducted.
    /// </summary>
    [JsonPropertyName("estimatedDeductionDate")]
    public DateTime? EstimatedDeductionDate { get; init; }

    /// <summary>
    /// Date the payment was processed. Use this field if the payment has already been deducted.
    /// </summary>
    [JsonPropertyName("processedAt")]
    public DateTime? ProcessedAt { get; init; }

    /// <summary>
    /// ID of payment source.
    /// </summary>
    [JsonPropertyName("paymentSourceId")]
    public string PaymentSourceId { get; init; }

    /// <summary>
    /// ID of payment destination.
    /// </summary>
    [JsonPropertyName("paymentDestinationId")]
    public string PaymentDestinationId { get; init; }

    /// <summary>
    /// Options for the payment destination. Depending on the payment destination, this may include things such as check delivery method.
    /// </summary>
    [JsonPropertyName("paymentDestinationOptions")]
    public PaymentDestinationOptions? PaymentDestinationOptions { get; init; }
}
