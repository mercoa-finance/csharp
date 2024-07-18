namespace Mercoa.Client;

public record BankLookupRequest
{
    /// <summary>
    /// Routing number to validate
    /// </summary>
    public required string RoutingNumber { get; init; }
}
