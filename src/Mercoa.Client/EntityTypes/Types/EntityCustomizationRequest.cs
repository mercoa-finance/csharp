using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityCustomizationRequest
{
    [JsonPropertyName("metadata")]
    public IEnumerable<MetadataCustomizationRequest>? Metadata { get; set; }

    [JsonPropertyName("paymentSource")]
    public IEnumerable<PaymentMethodCustomizationRequest>? PaymentSource { get; set; }

    [JsonPropertyName("backupDisbursement")]
    public IEnumerable<PaymentMethodCustomizationRequest>? BackupDisbursement { get; set; }

    [JsonPropertyName("paymentDestination")]
    public IEnumerable<PaymentMethodCustomizationRequest>? PaymentDestination { get; set; }

    [JsonPropertyName("ocr")]
    public OcrCustomizationRequest? Ocr { get; set; }

    [JsonPropertyName("notifications")]
    public NotificationCustomizationRequest? Notifications { get; set; }

    [JsonPropertyName("workflow")]
    public WorkflowCustomizationRequest? Workflow { get; set; }
}
