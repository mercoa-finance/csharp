using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class PaymentMethodsRequest
{
    /// <summary>
    /// List of payment methods that can be used to pay invoices.
    /// </summary>
    [JsonPropertyName("payerPayments")]
    public List<PaymentRailRequest> PayerPayments { get; init; }

    /// <summary>
    /// List of payment methods that can be created by a payor to send disbursements.
    /// </summary>
    [JsonPropertyName("backupDisbursements")]
    public List<PaymentRailRequest> BackupDisbursements { get; init; }

    /// <summary>
    /// List of payment methods that can be created by a payee to receive disbursements.
    /// </summary>
    [JsonPropertyName("vendorDisbursements")]
    public List<PaymentRailRequest> VendorDisbursements { get; init; }
}
