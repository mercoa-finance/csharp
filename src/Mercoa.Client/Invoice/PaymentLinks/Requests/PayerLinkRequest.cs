namespace Mercoa.Client.Invoice;

public record PayerLinkRequest
{
    /// <summary>
    /// Expressed in seconds or a string describing a time span. The default is 30d.
    /// </summary>
    public string? ExpiresIn { get; set; }
}
