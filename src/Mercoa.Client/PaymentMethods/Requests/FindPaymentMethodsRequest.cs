namespace Mercoa.Client;

public record FindPaymentMethodsRequest
{
    /// <summary>
    /// Number of payment methods to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// The ID of the payment method to start after. If not provided, the first page of payment methods will be returned.
    /// </summary>
    public string? StartingAfter { get; set; }

    /// <summary>
    /// Type of payment method to filter
    /// </summary>
    public IEnumerable<PaymentMethodType> Type { get; set; } = new List<PaymentMethodType>();

    /// <summary>
    /// Entity ID to filter
    /// </summary>
    public IEnumerable<string> EntityId { get; set; } = new List<string>();
}
