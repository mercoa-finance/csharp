using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceTemplateRequestBase
{
    [JsonPropertyName("status")]
    public InvoiceStatus? Status { get; set; }

    /// <summary>
    /// Total amount of invoice in major units. If the entered amount has more decimal places than the currency supports, trailing decimals will be truncated.
    /// </summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    /// <summary>
    /// Currency code for the amount. Defaults to USD.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? Currency { get; set; }

    /// <summary>
    /// Date the invoice was issued.
    /// </summary>
    [JsonPropertyName("invoiceDate")]
    public DateTime? InvoiceDate { get; set; }

    /// <summary>
    /// Initial date when funds are scheduled to be deducted from payer's account.
    /// </summary>
    [JsonPropertyName("deductionDate")]
    public DateTime? DeductionDate { get; set; }

    /// <summary>
    /// Due date of invoice.
    /// </summary>
    [JsonPropertyName("dueDate")]
    public DateTime? DueDate { get; set; }

    [JsonPropertyName("invoiceNumber")]
    public string? InvoiceNumber { get; set; }

    /// <summary>
    /// Note to self or memo on invoice.
    /// </summary>
    [JsonPropertyName("noteToSelf")]
    public string? NoteToSelf { get; set; }

    [JsonPropertyName("serviceStartDate")]
    public DateTime? ServiceStartDate { get; set; }

    [JsonPropertyName("serviceEndDate")]
    public DateTime? ServiceEndDate { get; set; }

    /// <summary>
    /// ID or foreign ID of the payer of this invoice.
    /// </summary>
    [JsonPropertyName("payerId")]
    public string? PayerId { get; set; }

    /// <summary>
    /// ID of payment source for this invoice. If not provided, will attempt to use the default payment source for the payer when creating an invoice if a default payment source exists for the payer.
    /// </summary>
    [JsonPropertyName("paymentSourceId")]
    public string? PaymentSourceId { get; set; }

    /// <summary>
    /// ID or foreign ID of the vendor of this invoice.
    /// </summary>
    [JsonPropertyName("vendorId")]
    public string? VendorId { get; set; }

    /// <summary>
    /// ID of payment destination for this invoice. If not provided, will attempt to use the default payment destination for the vendor when creating an invoice if a default payment destination exists for the vendor.
    /// </summary>
    [JsonPropertyName("paymentDestinationId")]
    public string? PaymentDestinationId { get; set; }

    /// <summary>
    /// Options for the payment destination. Depending on the payment destination, this may include things such as check delivery method.
    /// </summary>
    [JsonPropertyName("paymentDestinationOptions")]
    public object? PaymentDestinationOptions { get; set; }

    /// <summary>
    /// Set approvers for this invoice.
    /// </summary>
    [JsonPropertyName("approvers")]
    public IEnumerable<ApprovalSlotAssignment>? Approvers { get; set; }

    /// <summary>
    /// Metadata associated with this invoice.
    /// </summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// Base64 encoded image or PDF of invoice document. PNG, JPG, WEBP, and PDF are supported. 10MB max. If the invoice already has a document, this will add a new document to the invoice.
    /// </summary>
    [JsonPropertyName("document")]
    public string? Document { get; set; }

    /// <summary>
    /// User ID or Foreign ID of entity user who created this invoice.
    /// </summary>
    [JsonPropertyName("creatorUserId")]
    public string? CreatorUserId { get; set; }

    /// <summary>
    /// If using a custom payment method, you can override the default fees for this invoice. If not provided, the default fees for the custom payment method will be used.
    /// </summary>
    [JsonPropertyName("fees")]
    public InvoiceFeesRequest? Fees { get; set; }

    /// <summary>
    /// If true, this invoice will be paid as a batch payment. Batches are automatically determined by Mercoa based on the payment source, destination, and scheduled payment date.
    /// </summary>
    [JsonPropertyName("batchPayment")]
    public bool? BatchPayment { get; set; }

    /// <summary>
    /// If this is a recurring invoice, this will be the payment schedule for the invoice. If not provided, this will be a one-time invoice.
    /// </summary>
    [JsonPropertyName("paymentSchedule")]
    public object? PaymentSchedule { get; set; }
}