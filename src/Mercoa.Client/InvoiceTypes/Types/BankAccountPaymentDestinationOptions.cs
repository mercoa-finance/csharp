using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class BankAccountPaymentDestinationOptions
{
    /// <summary>
    /// Delivery method for ACH payments. Defaults to ACH_SAME_DAY.
    /// </summary>
    [JsonPropertyName("delivery")]
    public BankDeliveryMethod? Delivery { get; init; }
}
