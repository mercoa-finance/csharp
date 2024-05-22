using Mercoa.Client;

namespace Mercoa.Client.Entity;

public class GetAllPaymentMethodsRequest
{
    /// <summary>
    /// Type of payment method to filter
    /// </summary>
    public PaymentMethodType? Type { get; init; }
}
