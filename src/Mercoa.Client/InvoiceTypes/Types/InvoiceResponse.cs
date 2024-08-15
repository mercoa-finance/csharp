using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record InvoiceResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("status")]
    public required InvoiceStatus Status { get; init; }

    /// <summary>
    /// Total amount of invoice in major units
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
    /// Initial date when funds are scheduled to be deducted from payer's account. The actual deduction date may differ from this date, and will be reflected in the processedAt field.
    /// </summary>
    [JsonPropertyName("deductionDate")]
    public DateTime? DeductionDate { get; init; }

    /// <summary>
    /// If this is a recurring invoice, this will be the next date when funds are scheduled to be deducted from payer's account.
    /// </summary>
    [JsonPropertyName("nextDeductionDate")]
    public DateTime? NextDeductionDate { get; init; }

    /// <summary>
    /// Date when the invoice payment was processed.
    /// </summary>
    [JsonPropertyName("processedAt")]
    public DateTime? ProcessedAt { get; init; }

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

    [JsonPropertyName("noteToSelf")]
    public string? NoteToSelf { get; init; }

    [JsonPropertyName("serviceStartDate")]
    public DateTime? ServiceStartDate { get; init; }

    [JsonPropertyName("serviceEndDate")]
    public DateTime? ServiceEndDate { get; init; }

    [JsonPropertyName("payerId")]
    public string? PayerId { get; init; }

    [JsonPropertyName("payer")]
    public CounterpartyResponse? Payer { get; init; }

    [JsonPropertyName("paymentSource")]
    public object? PaymentSource { get; init; }

    [JsonPropertyName("paymentSourceId")]
    public string? PaymentSourceId { get; init; }

    [JsonPropertyName("vendorId")]
    public string? VendorId { get; init; }

    [JsonPropertyName("vendor")]
    public CounterpartyResponse? Vendor { get; init; }

    [JsonPropertyName("paymentDestination")]
    public object? PaymentDestination { get; init; }

    [JsonPropertyName("paymentDestinationId")]
    public string? PaymentDestinationId { get; init; }

    [JsonPropertyName("paymentDestinationOptions")]
    public object? PaymentDestinationOptions { get; init; }

    /// <summary>
    /// True if the payment destination has been confirmed by the vendor. False if the payment destination has been set (for example, a check to an address) but has not been confirmed by the vendor.
    /// </summary>
    [JsonPropertyName("paymentDestinationConfirmed")]
    public required bool PaymentDestinationConfirmed { get; init; }

    /// <summary>
    /// True if the invoice has documents attached.
    /// </summary>
    [JsonPropertyName("hasDocuments")]
    public required bool HasDocuments { get; init; }

    /// <summary>
    /// True if the invoice was created by an incoming email.
    /// </summary>
    [JsonPropertyName("hasSourceEmail")]
    public required bool HasSourceEmail { get; init; }

    [JsonPropertyName("comments")]
    public IEnumerable<CommentResponse>? Comments { get; init; }

    [JsonPropertyName("lineItems")]
    public IEnumerable<InvoiceLineItemResponse>? LineItems { get; init; }

    [JsonPropertyName("approvers")]
    public IEnumerable<ApprovalSlot> Approvers { get; init; } = new List<ApprovalSlot>();

    [JsonPropertyName("approvalPolicy")]
    public IEnumerable<ApprovalPolicyResponse> ApprovalPolicy { get; init; } =
        new List<ApprovalPolicyResponse>();

    /// <summary>
    /// Metadata associated with this invoice.
    /// </summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, string> Metadata { get; init; } = new Dictionary<string, string>();

    /// <summary>
    /// The ID used to identify this invoice in your system. This ID must be unique within each creatorEntity in your system, e.g. two invoices with the same creatorEntity may not have the same foreign ID.
    /// </summary>
    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; init; }

    /// <summary>
    /// The ID of the entity who created this invoice.
    /// </summary>
    [JsonPropertyName("creatorEntityId")]
    public string? CreatorEntityId { get; init; }

    /// <summary>
    /// Entity user who created this invoice.
    /// </summary>
    [JsonPropertyName("creatorUser")]
    public EntityUserResponse? CreatorUser { get; init; }

    /// <summary>
    /// If the invoice failed to be paid, this field will be populated with the type of failure.
    /// </summary>
    [JsonPropertyName("failureType")]
    public InvoiceFailureType? FailureType { get; init; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; init; }

    /// <summary>
    /// Fees associated with this invoice.
    /// </summary>
    [JsonPropertyName("fees")]
    public InvoiceFeesResponse? Fees { get; init; }

    /// <summary>
    /// If this is a recurring invoice, this will be the payment schedule for the invoice. If not provided, this will be a one-time invoice.
    /// </summary>
    [JsonPropertyName("paymentSchedule")]
    public object? PaymentSchedule { get; init; }
}
