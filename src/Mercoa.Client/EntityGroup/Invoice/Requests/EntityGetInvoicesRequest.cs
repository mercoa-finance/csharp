using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.EntityGroup;

public record EntityGetInvoicesRequest
{
    /// <summary>
    /// Return only invoices that are receivable by the entity.
    /// </summary>
    public bool? ExcludePayables { get; set; }

    /// <summary>
    /// Return only invoices that are payable by the entity.
    /// </summary>
    public bool? ExcludeReceivables { get; set; }

    /// <summary>
    /// Start date for invoice created on date filter.
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// End date for invoice created date filter.
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
    /// Filter invoices by metadata. Each filter will be applied as an AND condition. Duplicate keys will be ignored.
    /// </summary>
    public IEnumerable<MetadataFilter> Metadata { get; set; } = new List<MetadataFilter>();

    /// <summary>
    /// Find invoices by vendor name, invoice number, or amount. Partial matches are supported.
    /// </summary>
    public string? Search { get; set; }

    /// <summary>
    /// Filter invoices by payer ID or payer foreign ID.
    /// </summary>
    public IEnumerable<string> PayerId { get; set; } = new List<string>();

    /// <summary>
    /// Filter invoices by vendor ID or vendor foreign ID.
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
    /// Invoice status to filter on.
    /// </summary>
    public IEnumerable<InvoiceStatus> Status { get; set; } = new List<InvoiceStatus>();

    /// <summary>
    /// Filter invoices by recurring status
    /// </summary>
    public IEnumerable<PaymentType>? PaymentType { get; set; }
}
