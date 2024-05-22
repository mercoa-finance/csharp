namespace Mercoa.Client.Invoice;

public class GetInvoice
{
    /// <summary>
    /// DEPRECATED. Fees are now included by default in the response.
    /// </summary>
    public bool? IncludeFees { get; init; }
}
