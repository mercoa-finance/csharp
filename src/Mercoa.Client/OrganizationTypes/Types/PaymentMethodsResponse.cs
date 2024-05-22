using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class PaymentMethodsResponse
{
    /// <summary>
    /// List of payment methods that can be used to pay invoices.
    /// </summary>
    [JsonPropertyName("payerPayments")]
    public List<PaymentRailResponse> PayerPayments { get; init; }

    /// <summary>
    /// List of payment methods that can be created by a payor to send disbursements.
    /// </summary>
    [JsonPropertyName("backupDisbursements")]
    public List<PaymentRailResponse> BackupDisbursements { get; init; }

    /// <summary>
    /// List of payment methods that can be created by a payee to receive disbursements.
    /// </summary>
    [JsonPropertyName("vendorDisbursements")]
    public List<PaymentRailResponse> VendorDisbursements { get; init; }
}
