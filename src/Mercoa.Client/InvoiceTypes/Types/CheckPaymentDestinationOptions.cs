using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CheckPaymentDestinationOptions
{
    /// <summary>
    /// Delivery method for check disbursements. Defaults to MAIL.
    /// </summary>
    [JsonPropertyName("delivery")]
    public CheckDeliveryMethod? Delivery { get; set; }

    /// <summary>
    /// If true, prints the invoice description (noteToSelf) on the check note. Defaults to false.
    /// </summary>
    [JsonPropertyName("printDescription")]
    public bool? PrintDescription { get; set; }
}
