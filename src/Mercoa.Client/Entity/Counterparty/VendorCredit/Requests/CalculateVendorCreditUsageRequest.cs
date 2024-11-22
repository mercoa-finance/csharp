using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.Entity.Counterparty;

public record CalculateVendorCreditUsageRequest
{
    /// <summary>
    /// The amount of the invoice to calculate vendor credit usage for.
    /// </summary>
    public required double Amount { get; set; }

    /// <summary>
    /// The currency of the invoice to calculate vendor credit usage for. Defaults to USD.
    /// </summary>
    public CurrencyCode? Currency { get; set; }

    /// <summary>
    /// List of invoice IDs to exclude from the calculation. If not provided or an empty list, no invoices will be excluded. This is useful for recalculating vendor credit usage on invoices that already have vendor credits applied.
    /// </summary>
    public IEnumerable<string>? ExcludedInvoiceIds { get; set; }

    /// <summary>
    /// List of vendor credit IDs to include in the calculation. If not provided, all applicable vendor credits will be included, while an empty list will not include ANY vendor credits. This is useful for recalculating vendor credit usage on invoices that have a fixed list of applied vendor credits (e.g. a SCHEDULED or PENDING invoice).
    /// </summary>
    public IEnumerable<string>? IncludedVendorCreditIds { get; set; }
}
