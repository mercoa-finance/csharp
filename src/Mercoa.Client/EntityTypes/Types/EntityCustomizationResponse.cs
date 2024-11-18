using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityCustomizationResponse
{
    [JsonPropertyName("metadata")]
    public IEnumerable<MetadataCustomizationRequest> Metadata { get; set; } =
        new List<MetadataCustomizationRequest>();

    [JsonPropertyName("paymentSource")]
    public IEnumerable<PaymentMethodCustomizationRequest> PaymentSource { get; set; } =
        new List<PaymentMethodCustomizationRequest>();

    [JsonPropertyName("backupDisbursement")]
    public IEnumerable<PaymentMethodCustomizationRequest> BackupDisbursement { get; set; } =
        new List<PaymentMethodCustomizationRequest>();

    [JsonPropertyName("paymentDestination")]
    public IEnumerable<PaymentMethodCustomizationRequest> PaymentDestination { get; set; } =
        new List<PaymentMethodCustomizationRequest>();

    [JsonPropertyName("ocr")]
    public required OcrCustomizationRequest Ocr { get; set; }

    [JsonPropertyName("notifications")]
    public required NotificationCustomizationRequest Notifications { get; set; }
}
