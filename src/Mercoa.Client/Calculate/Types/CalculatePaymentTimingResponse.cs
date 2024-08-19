using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CalculatePaymentTimingResponse
{
    /// <summary>
    /// Estimated date the payment will be or was processed.
    /// </summary>
    [JsonPropertyName("estimatedProcessingDate")]
    public required DateTime EstimatedProcessingDate { get; set; }

    /// <summary>
    /// Number of business days between the estimated processing date and the estimated settlement date. This does not take into account bank holidays or weekends.
    /// </summary>
    [JsonPropertyName("businessDays")]
    public required int BusinessDays { get; set; }

    /// <summary>
    /// Estimated payment time in days. This time takes into account bank holidays and weekends.
    /// </summary>
    [JsonPropertyName("estimatedProcessingTime")]
    public required int EstimatedProcessingTime { get; set; }

    /// <summary>
    /// Estimated date the payment will be or was settled. This is the same as the request's deductionDate plus the paymentTiming.
    /// </summary>
    [JsonPropertyName("estimatedSettlementDate")]
    public required DateTime EstimatedSettlementDate { get; set; }
}
