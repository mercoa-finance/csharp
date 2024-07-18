namespace Mercoa.Client.Invoice;

public record SendPayerEmail
{
    /// <summary>
    /// Whether to attach the invoice to the email
    /// </summary>
    public bool? AttachInvoice { get; init; }
}
