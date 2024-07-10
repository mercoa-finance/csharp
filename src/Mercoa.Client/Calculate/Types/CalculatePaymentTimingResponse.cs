using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class CalculatePaymentTimingResponse
{
    /// <summary>
    /// Estimated date the payment will be or was processed.
    /// </summary>
    [JsonPropertyName("estimatedProcessingDate")]
    public DateTime EstimatedProcessingDate { get; init; }

    /// <summary>
    /// Number of business days between the estimated processing date and the estimated settlement date. This does not take into account bank holidays or weekends.
    /// </summary>
    [JsonPropertyName("businessDays")]
    public int BusinessDays { get; init; }

    /// <summary>
    /// Estimated payment time in days. This time takes into account bank holidays and weekends.
    /// </summary>
    [JsonPropertyName("estimatedProcessingTime")]
    public int EstimatedProcessingTime { get; init; }

    /// <summary>
    /// Estimated date the payment will be or was settled. This is the same as the request's deductionDate plus the paymentTiming.
    /// </summary>
    [JsonPropertyName("estimatedSettlementDate")]
    public DateTime EstimatedSettlementDate { get; init; }
}
