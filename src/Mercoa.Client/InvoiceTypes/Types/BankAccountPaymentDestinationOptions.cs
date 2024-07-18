using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record BankAccountPaymentDestinationOptions
{
    /// <summary>
    /// Delivery method for ACH payments. Defaults to ACH_SAME_DAY.
    /// </summary>
    [JsonPropertyName("delivery")]
    public BankDeliveryMethod? Delivery { get; init; }

    /// <summary>
    /// ACH Statement Description. By default, this will be 'AP' followed by the first 8 characters of the invoice ID. Must be at least 4 characters and no more than 10 characters, and follow this regex pattern ^[a-zA-Z0-9\-#.$&* ]{4,10}$
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }
}
