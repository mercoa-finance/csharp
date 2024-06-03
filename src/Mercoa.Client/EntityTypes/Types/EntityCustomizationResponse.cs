using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class EntityCustomizationResponse
{
    [JsonPropertyName("metadata")]
    public IEnumerable<MetadataCustomizationRequest> Metadata { get; init; }

    [JsonPropertyName("paymentSource")]
    public IEnumerable<PaymentMethodCustomizationRequest> PaymentSource { get; init; }

    [JsonPropertyName("backupDisbursement")]
    public IEnumerable<PaymentMethodCustomizationRequest> BackupDisbursement { get; init; }

    [JsonPropertyName("paymentDestination")]
    public IEnumerable<PaymentMethodCustomizationRequest> PaymentDestination { get; init; }
}
