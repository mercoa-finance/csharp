using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class CheckPaymentDestinationOptions
{
    /// <summary>
    /// Delivery method for check disbursements. Defaults to MAIL.
    /// </summary>
    [JsonPropertyName("delivery")]
    public CheckDeliveryMethod? Delivery { get; init; }
}
