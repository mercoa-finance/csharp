using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class EntityCustomizationResponse
{
    [JsonPropertyName("metadata")]
    public List<MetadataCustomizationRequest> Metadata { get; init; }

    [JsonPropertyName("paymentSource")]
    public List<PaymentMethodCustomizationRequest> PaymentSource { get; init; }

    [JsonPropertyName("backupDisbursement")]
    public List<PaymentMethodCustomizationRequest> BackupDisbursement { get; init; }

    [JsonPropertyName("paymentDestination")]
    public List<PaymentMethodCustomizationRequest> PaymentDestination { get; init; }
}
