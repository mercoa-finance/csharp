using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class InvoiceResponse
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("status")]
    public InvoiceStatus Status { get; init; }

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
    /// Date when funds will be deducted from payer's account.
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

    [JsonPropertyName("noteToSelf")]
    public string? NoteToSelf { get; init; }

    [JsonPropertyName("serviceStartDate")]
    public DateTime? ServiceStartDate { get; init; }

    [JsonPropertyName("serviceEndDate")]
    public DateTime? ServiceEndDate { get; init; }

    [JsonPropertyName("payerId")]
    public string? PayerId { get; init; }

    [JsonPropertyName("payer")]
    public EntityResponse? Payer { get; init; }

    [JsonPropertyName("paymentSource")]
    public PaymentMethodResponse? PaymentSource { get; init; }

    [JsonPropertyName("paymentSourceId")]
    public string? PaymentSourceId { get; init; }

    [JsonPropertyName("vendorId")]
    public string? VendorId { get; init; }

    [JsonPropertyName("vendor")]
    public EntityResponse? Vendor { get; init; }

    [JsonPropertyName("paymentDestination")]
    public PaymentMethodResponse? PaymentDestination { get; init; }

    [JsonPropertyName("paymentDestinationId")]
    public string? PaymentDestinationId { get; init; }

    [JsonPropertyName("paymentDestinationOptions")]
    public PaymentDestinationOptions? PaymentDestinationOptions { get; init; }

    /// <summary>
    /// True if the payment destination has been confirmed by the vendor. False if the payment destination has been set (for example, a check to an address) but has not been confirmed by the vendor.
    /// </summary>
    [JsonPropertyName("paymentDestinationConfirmed")]
    public bool PaymentDestinationConfirmed { get; init; }

    /// <summary>
    /// True if the invoice has documents attached.
    /// </summary>
    [JsonPropertyName("hasDocuments")]
    public bool HasDocuments { get; init; }

    /// <summary>
    /// True if the invoice was created by an incoming email.
    /// </summary>
    [JsonPropertyName("hasSourceEmail")]
    public bool HasSourceEmail { get; init; }

    [JsonPropertyName("comments")]
    public IEnumerable<CommentResponse>? Comments { get; init; }

    [JsonPropertyName("lineItems")]
    public IEnumerable<InvoiceLineItemResponse>? LineItems { get; init; }

    [JsonPropertyName("approvers")]
    public IEnumerable<ApprovalSlot> Approvers { get; init; }

    [JsonPropertyName("approvalPolicy")]
    public IEnumerable<ApprovalPolicyResponse> ApprovalPolicy { get; init; }

    /// <summary>
    /// Metadata associated with this invoice.
    /// </summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, string> Metadata { get; init; }

    /// <summary>
    /// The ID used to identify this invoice in your system. This ID must be unique within each creatorEntity in your system, e.g. two invoices with the same creatorEntity may not have the same foreign ID.
    /// </summary>
    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; init; }

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

    [JsonPropertyName("processedAt")]
    public DateTime? ProcessedAt { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }

    /// <summary>
    /// Fees associated with this invoice.
    /// </summary>
    [JsonPropertyName("fees")]
    public InvoiceFeesResponse? Fees { get; init; }
}
