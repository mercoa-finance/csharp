using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class InvoiceUpdateRequest
{
    /// <summary>
    /// ID of entity who created this invoice. If creating a payable invoice (AP), this must be the same as the payerId. If creating a receivable invoice (AR), this must be the same as the vendorId.
    /// </summary>
    [JsonPropertyName("creatorEntityId")]
    public string? CreatorEntityId { get; init; }

    [JsonPropertyName("status")]
    public InvoiceStatus? Status { get; init; }

    /// <summary>
    /// Total amount of invoice in major units. If the entered amount has more decimal places than the currency supports, trailing decimals will be truncated.
    /// </summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; init; }

    /// <summary>
    /// Currency code for the amount. Defaults to USD.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? Currency { get; init; }

    /// <summary>
    /// Date the invoice was issued.
    /// </summary>
    [JsonPropertyName("invoiceDate")]
    public DateTime? InvoiceDate { get; init; }

    /// <summary>
    /// Date when funds are scheduled to be deducted from payer's account.
    /// </summary>
    [JsonPropertyName("deductionDate")]
    public DateTime? DeductionDate { get; init; }

    /// <summary>
    /// Date of funds settlement.
    /// </summary>
    [JsonPropertyName("settlementDate")]
    public DateTime? SettlementDate { get; init; }

    /// <summary>
    /// Due date of invoice.
    /// </summary>
    [JsonPropertyName("dueDate")]
    public DateTime? DueDate { get; init; }

    [JsonPropertyName("invoiceNumber")]
    public string? InvoiceNumber { get; init; }

    /// <summary>
    /// Note to self or memo on invoice.
    /// </summary>
    [JsonPropertyName("noteToSelf")]
    public string? NoteToSelf { get; init; }

    [JsonPropertyName("serviceStartDate")]
    public DateTime? ServiceStartDate { get; init; }

    [JsonPropertyName("serviceEndDate")]
    public DateTime? ServiceEndDate { get; init; }

    [JsonPropertyName("payerId")]
    public string? PayerId { get; init; }

    /// <summary>
    /// ID of payment source for this invoice. If not provided, will attempt to use the default payment source for the payer when creating an invoice if a default payment source exists for the payer.
    /// </summary>
    [JsonPropertyName("paymentSourceId")]
    public string? PaymentSourceId { get; init; }

    [JsonPropertyName("vendorId")]
    public string? VendorId { get; init; }

    /// <summary>
    /// ID of payment destination for this invoice. If not provided, will attempt to use the default payment destination for the vendor when creating an invoice if a default payment destination exists for the vendor.
    /// </summary>
    [JsonPropertyName("paymentDestinationId")]
    public string? PaymentDestinationId { get; init; }

    /// <summary>
    /// Options for the payment destination. Depending on the payment destination, this may include things such as check delivery method.
    /// </summary>
    [JsonPropertyName("paymentDestinationOptions")]
    public PaymentDestinationOptions? PaymentDestinationOptions { get; init; }

    /// <summary>
    /// Set approvers for this invoice.
    /// </summary>
    [JsonPropertyName("approvers")]
    public IEnumerable<ApprovalSlotAssignment>? Approvers { get; init; }

    [JsonPropertyName("lineItems")]
    public IEnumerable<InvoiceLineItemRequest>? LineItems { get; init; }

    /// <summary>
    /// Metadata associated with this invoice. You can specify up to 10 keys, with key names up to 40 characters long and values up to 200 characters long.
    /// </summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, string>? Metadata { get; init; }

    /// <summary>
    /// The ID used to identify this invoice in your system. This ID must be unique within each creatorEntity in your system, e.g. two invoices with the same creatorEntity may not have the same foreign ID.
    /// </summary>
    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; init; }

    /// <summary>
    /// Base64 encoded image or PDF of invoice document. PNG, JPG, WEBP, and PDF are supported. 10MB max. If the invoice already has a document, this will add a new document to the invoice.
    /// </summary>
    [JsonPropertyName("document")]
    public string? Document { get; init; }

    /// <summary>
    /// DEPRECATED. Use document field instead.
    /// </summary>
    [JsonPropertyName("uploadedImage")]
    public string? UploadedImage { get; init; }

    /// <summary>
    /// ID of entity user who created this invoice.
    /// </summary>
    [JsonPropertyName("creatorUserId")]
    public string? CreatorUserId { get; init; }

    /// <summary>
    /// If the invoice failed to be paid, indicate the failure reason. Only applicable for invoices with custom payment methods.
    /// </summary>
    [JsonPropertyName("failureType")]
    public InvoiceFailureType? FailureType { get; init; }
}
