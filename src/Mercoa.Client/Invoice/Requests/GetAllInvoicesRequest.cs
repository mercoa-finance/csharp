using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.Invoice;

public record GetAllInvoicesRequest
{
    /// <summary>
    /// Filter invoices by the ID of the entity that created the invoice.
    /// </summary>
    public IEnumerable<string> EntityId { get; set; } = new List<string>();

    /// <summary>
    /// Start date filter. Defaults to CREATED_AT unless specified the dateType is specified
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// End date filter. Defaults to CREATED_AT unless specified the dateType is specified
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Type of date to filter by if startDate and endDate filters are provided. Defaults to CREATED_AT.
    /// </summary>
    public InvoiceDateFilter? DateType { get; set; }

    /// <summary>
    /// Field to order invoices by. Defaults to CREATED_AT.
    /// </summary>
    public InvoiceOrderByField? OrderBy { get; set; }

    /// <summary>
    /// Direction to order invoices by. Defaults to asc.
    /// </summary>
    public OrderDirection? OrderDirection { get; set; }

    /// <summary>
    /// Number of invoices to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// The ID of the invoice to start after. If not provided, the first page of invoices will be returned.
    /// </summary>
    public string? StartingAfter { get; set; }

    /// <summary>
    /// Find invoices by vendor name, invoice number, or amount. Partial matches are supported.
    /// </summary>
    public string? Search { get; set; }

    /// <summary>
    /// Filter invoices by metadata. Each filter will be applied as an AND condition. Duplicate keys will be ignored.
    /// </summary>
    public IEnumerable<InvoiceMetadataFilter> Metadata { get; set; } =
        new List<InvoiceMetadataFilter>();

    /// <summary>
    /// Filter invoices by line item metadata. Each filter will be applied as an AND condition. Duplicate keys will be ignored.
    /// </summary>
    public IEnumerable<InvoiceMetadataFilter> LineItemMetadata { get; set; } =
        new List<InvoiceMetadataFilter>();

    /// <summary>
    /// Filter invoices by line item GL account ID. Each filter will be applied as an OR condition. Duplicate keys will be ignored.
    /// </summary>
    public IEnumerable<string> LineItemGlAccountId { get; set; } = new List<string>();

    /// <summary>
    /// Filter invoices by payer ID.
    /// </summary>
    public IEnumerable<string> PayerId { get; set; } = new List<string>();

    /// <summary>
    /// Filter invoices by vendor ID.
    /// </summary>
    public IEnumerable<string> VendorId { get; set; } = new List<string>();

    /// <summary>
    /// Filter invoices by assigned approver user ID.
    /// </summary>
    public IEnumerable<string> ApproverId { get; set; } = new List<string>();

    /// <summary>
    /// Filter invoices by approver action. Needs to be used with approverId. For example, if you want to find all invoices that have been approved by a specific user, you would use approverId and approverAction=APPROVE.
    /// </summary>
    public IEnumerable<ApproverAction> ApproverAction { get; set; } = new List<ApproverAction>();

    /// <summary>
    /// Filter invoices by invoice ID.
    /// </summary>
    public IEnumerable<string> InvoiceId { get; set; } = new List<string>();

    /// <summary>
    /// Invoice status to filter on
    /// </summary>
    public IEnumerable<InvoiceStatus> Status { get; set; } = new List<InvoiceStatus>();

    /// <summary>
    /// Filter invoices by recurring status
    /// </summary>
    public IEnumerable<PaymentType>? PaymentType { get; set; }
}
