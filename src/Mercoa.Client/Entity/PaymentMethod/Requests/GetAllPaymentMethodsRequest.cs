using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.Entity;

public record GetAllPaymentMethodsRequest
{
    /// <summary>
    /// Type of payment method to filter
    /// </summary>
    public PaymentMethodType? Type { get; init; }
}
