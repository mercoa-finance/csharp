using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record EntityCustomizationRequest
{
    [JsonPropertyName("metadata")]
    public IEnumerable<MetadataCustomizationRequest> Metadata { get; init; } =
        new List<MetadataCustomizationRequest>();

    [JsonPropertyName("paymentSource")]
    public IEnumerable<PaymentMethodCustomizationRequest> PaymentSource { get; init; } =
        new List<PaymentMethodCustomizationRequest>();

    [JsonPropertyName("backupDisbursement")]
    public IEnumerable<PaymentMethodCustomizationRequest> BackupDisbursement { get; init; } =
        new List<PaymentMethodCustomizationRequest>();

    [JsonPropertyName("paymentDestination")]
    public IEnumerable<PaymentMethodCustomizationRequest> PaymentDestination { get; init; } =
        new List<PaymentMethodCustomizationRequest>();
}
