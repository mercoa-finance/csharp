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
}
