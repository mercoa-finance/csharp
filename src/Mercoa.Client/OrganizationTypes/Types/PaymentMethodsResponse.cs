using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record PaymentMethodsResponse
{
    /// <summary>
    /// List of payment methods that can be used to pay invoices.
    /// </summary>
    [JsonPropertyName("payerPayments")]
    public IEnumerable<PaymentRailResponse> PayerPayments { get; set; } =
        new List<PaymentRailResponse>();

    /// <summary>
    /// List of payment methods that can be created by a payor to send disbursements.
    /// </summary>
    [JsonPropertyName("backupDisbursements")]
    public IEnumerable<PaymentRailResponse> BackupDisbursements { get; set; } =
        new List<PaymentRailResponse>();

    /// <summary>
    /// List of payment methods that can be created by a payee to receive disbursements.
    /// </summary>
    [JsonPropertyName("vendorDisbursements")]
    public IEnumerable<PaymentRailResponse> VendorDisbursements { get; set; } =
        new List<PaymentRailResponse>();
}
