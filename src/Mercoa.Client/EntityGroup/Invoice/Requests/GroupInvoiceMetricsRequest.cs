using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.EntityGroup;

public record GroupInvoiceMetricsRequest
{
    /// <summary>
    /// Find invoices by vendor name, invoice number, or amount. Partial matches are supported.
    /// </summary>
    public string? Search { get; set; }

    /// <summary>
    /// Only return invoices that are not payable by the entity. This will return only invoices that are receivable by the entity.
    /// </summary>
    public bool? ExcludePayables { get; set; }

    /// <summary>
    /// Only return invoices that are not receivable by the entity. This will return only invoices that are payable by the entity.
    /// </summary>
    public bool? ExcludeReceivables { get; set; }

    /// <summary>
    /// Return invoice metrics grouped by date.
    /// </summary>
    public InvoiceMetricsPerDateGroupBy? ReturnByDate { get; set; }

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
    /// Filter invoices by invoice ID.
    /// </summary>
    public IEnumerable<string> InvoiceId { get; set; } = new List<string>();

    /// <summary>
    /// Invoice status to filter on
    /// </summary>
    public IEnumerable<InvoiceStatus> Status { get; set; } = new List<InvoiceStatus>();

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
    /// DEPRECATED. Use startDate, endDate, and dateType instead. Start date for invoice dueDate filter.
    /// </summary>
    public DateTime? DueDateStart { get; set; }

    /// <summary>
    /// DEPRECATED. Use startDate, endDate, and dateType instead. End date for invoice dueDate filter.
    /// </summary>
    public DateTime? DueDateEnd { get; set; }

    /// <summary>
    /// DEPRECATED. Use startDate, endDate, and dateType instead. Start date for invoice created on date filter.
    /// </summary>
    public DateTime? CreatedDateStart { get; set; }

    /// <summary>
    /// DEPRECATED. Use startDate, endDate, and dateType instead. End date for invoice created date filter.
    /// </summary>
    public DateTime? CreatedDateEnd { get; set; }

    /// <summary>
    /// Currency to filter on
    /// </summary>
    public IEnumerable<CurrencyCode> Currency { get; set; } = new List<CurrencyCode>();
}
