using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record FindPaymentMethodsRequest
{
    /// <summary>
    /// Number of payment methods to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The ID of the payment method to start after. If not provided, the first page of payment methods will be returned.
    /// </summary>
    public string? StartingAfter { get; init; }

    /// <summary>
    /// Type of payment method to filter
    /// </summary>
    public PaymentMethodType? Type { get; init; }

    /// <summary>
    /// Entity ID to filter
    /// </summary>
    public string? EntityId { get; init; }
}
