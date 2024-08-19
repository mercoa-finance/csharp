namespace Mercoa.Client.Entity;

public record PlaidLinkTokenRequest
{
    /// <summary>
    /// ID of Bank Account to update
    /// </summary>
    public string? PaymentMethodId { get; set; }
}
