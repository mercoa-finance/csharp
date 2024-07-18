using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record PaymentMethodsRequest
{
    /// <summary>
    /// List of payment methods that can be used to pay invoices.
    /// </summary>
    [JsonPropertyName("payerPayments")]
    public IEnumerable<PaymentRailRequest> PayerPayments { get; init; } =
        new List<PaymentRailRequest>();

    /// <summary>
    /// List of payment methods that can be created by a payor to send disbursements.
    /// </summary>
    [JsonPropertyName("backupDisbursements")]
    public IEnumerable<PaymentRailRequest> BackupDisbursements { get; init; } =
        new List<PaymentRailRequest>();

    /// <summary>
    /// List of payment methods that can be created by a payee to receive disbursements.
    /// </summary>
    [JsonPropertyName("vendorDisbursements")]
    public IEnumerable<PaymentRailRequest> VendorDisbursements { get; init; } =
        new List<PaymentRailRequest>();
}
