using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.EntityGroup;

public record EntityGetInvoicesRequest
{
    /// <summary>
    /// Return only invoices that are receivable by the entity.
    /// </summary>
    public bool? ExcludePayables { get; init; }

    /// <summary>
    /// Return only invoices that are payable by the entity.
    /// </summary>
    public bool? ExcludeReceivables { get; init; }

    /// <summary>
    /// Start date for invoice created on date filter.
    /// </summary>
    public DateTime? StartDate { get; init; }

    /// <summary>
    /// End date for invoice created date filter.
    /// </summary>
    public DateTime? EndDate { get; init; }

    /// <summary>
    /// Field to order invoices by. Defaults to CREATED_AT.
    /// </summary>
    public InvoiceOrderByField? OrderBy { get; init; }

    /// <summary>
    /// Direction to order invoices by. Defaults to asc.
    /// </summary>
    public OrderDirection? OrderDirection { get; init; }

    /// <summary>
    /// Number of invoices to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The ID of the invoice to start after. If not provided, the first page of invoices will be returned.
    /// </summary>
    public string? StartingAfter { get; init; }

    /// <summary>
    /// Filter invoices by metadata. Each filter will be applied as an AND condition. Duplicate keys will be ignored.
    /// </summary>
    public InvoiceMetadataFilter? Metadata { get; init; }

    /// <summary>
    /// Find invoices by vendor name, invoice number, or amount. Partial matches are supported.
    /// </summary>
    public string? Search { get; init; }

    /// <summary>
    /// Filter invoices by payer ID.
    /// </summary>
    public string? PayerId { get; init; }

    /// <summary>
    /// Filter invoices by vendor ID.
    /// </summary>
    public string? VendorId { get; init; }

    /// <summary>
    /// Filter invoices by assigned approver user ID.
    /// </summary>
    public string? ApproverId { get; init; }

    /// <summary>
    /// Filter invoices by approver action. Needs to be used with approverId. For example, if you want to find all invoices that have been approved by a specific user, you would use approverId and approverAction=APPROVE.
    /// </summary>
    public ApproverAction? ApproverAction { get; init; }

    /// <summary>
    /// Filter invoices by invoice ID.
    /// </summary>
    public string? InvoiceId { get; init; }

    /// <summary>
    /// Invoice status to filter on.
    /// </summary>
    public InvoiceStatus? Status { get; init; }
}
