using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record PaymentMethodsResponse
{
    /// <summary>
    /// List of payment methods that can be used to pay invoices.
    /// </summary>
    [JsonPropertyName("payerPayments")]
    public IEnumerable<PaymentRailResponse> PayerPayments { get; init; } =
        new List<PaymentRailResponse>();

    /// <summary>
    /// List of payment methods that can be created by a payor to send disbursements.
    /// </summary>
    [JsonPropertyName("backupDisbursements")]
    public IEnumerable<PaymentRailResponse> BackupDisbursements { get; init; } =
        new List<PaymentRailResponse>();

    /// <summary>
    /// List of payment methods that can be created by a payee to receive disbursements.
    /// </summary>
    [JsonPropertyName("vendorDisbursements")]
    public IEnumerable<PaymentRailResponse> VendorDisbursements { get; init; } =
        new List<PaymentRailResponse>();
}
