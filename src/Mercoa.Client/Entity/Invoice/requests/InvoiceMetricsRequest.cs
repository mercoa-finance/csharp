using Mercoa.Client;

namespace Mercoa.Client.Entity;

public class InvoiceMetricsRequest
{
    /// <summary>
    /// Find invoices by vendor name, invoice number, or amount. Partial matches are supported.
    /// </summary>
    public string? Search { get; init; }

    /// <summary>
    /// Only return invoices that are not payable by the entity. This will return only invoices that are receivable by the entity.
    /// </summary>
    public bool? ExcludePayables { get; init; }

    /// <summary>
    /// Only return invoices that are not receivable by the entity. This will return only invoices that are payable by the entity.
    /// </summary>
    public bool? ExcludeReceivables { get; init; }

    /// <summary>
    /// Return invoice metrics grouped by date.
    /// </summary>
    public InvoiceMetricsPerDateGroupBy? ReturnByDate { get; init; }

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
    /// Filter invoices by invoice ID.
    /// </summary>
    public string? InvoiceId { get; init; }

    /// <summary>
    /// Invoice status to filter on
    /// </summary>
    public InvoiceStatus? Status { get; init; }

    /// <summary>
    /// Start date for invoice dueDate filter.
    /// </summary>
    public DateTime? DueDateStart { get; init; }

    /// <summary>
    /// End date for invoice dueDate filter.
    /// </summary>
    public DateTime? DueDateEnd { get; init; }

    /// <summary>
    /// Start date for invoice created on date filter.
    /// </summary>
    public DateTime? CreatedDateStart { get; init; }

    /// <summary>
    /// End date for invoice created date filter.
    /// </summary>
    public DateTime? CreatedDateEnd { get; init; }

    /// <summary>
    /// Currency to filter on
    /// </summary>
    public CurrencyCode? Currency { get; init; }
}
