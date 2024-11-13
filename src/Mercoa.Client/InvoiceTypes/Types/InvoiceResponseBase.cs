using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceResponseBase
{
    [JsonPropertyName("status")]
    public required InvoiceStatus Status { get; set; }

    /// <summary>
    /// Total amount of invoice in major units
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
    /// Initial date when funds are scheduled to be deducted from payer's account. The actual deduction date may differ from this date, and will be reflected in the processedAt field.
    /// </summary>
    [JsonPropertyName("deductionDate")]
    public DateTime? DeductionDate { get; set; }

    /// <summary>
    /// If this is a recurring invoice, this will be the next date when funds are scheduled to be deducted from payer's account.
    /// </summary>
    [JsonPropertyName("nextDeductionDate")]
    public DateTime? NextDeductionDate { get; set; }

    /// <summary>
    /// Due date of invoice.
    /// </summary>
    [JsonPropertyName("dueDate")]
    public DateTime? DueDate { get; set; }

    [JsonPropertyName("invoiceNumber")]
    public string? InvoiceNumber { get; set; }

    [JsonPropertyName("noteToSelf")]
    public string? NoteToSelf { get; set; }

    [JsonPropertyName("serviceStartDate")]
    public DateTime? ServiceStartDate { get; set; }

    [JsonPropertyName("serviceEndDate")]
    public DateTime? ServiceEndDate { get; set; }

    [JsonPropertyName("payerId")]
    public string? PayerId { get; set; }

    [JsonPropertyName("payer")]
    public CounterpartyResponse? Payer { get; set; }

    [JsonPropertyName("paymentSource")]
    public object? PaymentSource { get; set; }

    [JsonPropertyName("paymentSourceId")]
    public string? PaymentSourceId { get; set; }

    [JsonPropertyName("vendorId")]
    public string? VendorId { get; set; }

    [JsonPropertyName("vendor")]
    public CounterpartyResponse? Vendor { get; set; }

    [JsonPropertyName("paymentDestination")]
    public object? PaymentDestination { get; set; }

    [JsonPropertyName("paymentDestinationId")]
    public string? PaymentDestinationId { get; set; }

    [JsonPropertyName("paymentDestinationOptions")]
    public object? PaymentDestinationOptions { get; set; }

    /// <summary>
    /// True if the payment destination has been confirmed by the vendor. False if the payment destination has been set (for example, a check to an address) but has not been confirmed by the vendor.
    /// </summary>
    [JsonPropertyName("paymentDestinationConfirmed")]
    public required bool PaymentDestinationConfirmed { get; set; }

    /// <summary>
    /// If true, this invoice will be paid as a batch payment. Batches are automatically determined by Mercoa based on the payment source, destination, and scheduled payment date.
    /// </summary>
    [JsonPropertyName("batchPayment")]
    public bool? BatchPayment { get; set; }

    /// <summary>
    /// True if the invoice has documents attached.
    /// </summary>
    [JsonPropertyName("hasDocuments")]
    public required bool HasDocuments { get; set; }

    /// <summary>
    /// True if the invoice was created by an incoming email.
    /// </summary>
    [JsonPropertyName("hasSourceEmail")]
    public required bool HasSourceEmail { get; set; }

    [JsonPropertyName("lineItems")]
    public IEnumerable<InvoiceLineItemResponse>? LineItems { get; set; }

    [JsonPropertyName("approvers")]
    public IEnumerable<ApprovalSlot> Approvers { get; set; } = new List<ApprovalSlot>();

    [JsonPropertyName("approvalPolicy")]
    public IEnumerable<ApprovalPolicyResponse> ApprovalPolicy { get; set; } =
        new List<ApprovalPolicyResponse>();

    /// <summary>
    /// Metadata associated with this invoice.
    /// </summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();

    /// <summary>
    /// The ID of the entity who created this invoice.
    /// </summary>
    [JsonPropertyName("creatorEntityId")]
    public string? CreatorEntityId { get; set; }

    /// <summary>
    /// Entity user who created this invoice.
    /// </summary>
    [JsonPropertyName("creatorUser")]
    public EntityUserResponse? CreatorUser { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    [JsonPropertyName("comments")]
    public IEnumerable<CommentResponse>? Comments { get; set; }

    /// <summary>
    /// Fees associated with this invoice.
    /// </summary>
    [JsonPropertyName("fees")]
    public InvoiceFeesResponse? Fees { get; set; }

    /// <summary>
    /// If this is a recurring invoice, this will be the payment schedule for the invoice. If not provided, this will be a one-time invoice.
    /// </summary>
    [JsonPropertyName("paymentSchedule")]
    public object? PaymentSchedule { get; set; }
}
