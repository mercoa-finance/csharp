using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class PaymentRailResponse
{
    [JsonPropertyName("available")]
    public bool Available { get; init; }

    [JsonPropertyName("type")]
    public PaymentMethodType Type { get; init; }

    /// <summary>
    /// Name of the payment method. For custom payment methods, this is the ID of the schema.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("markup")]
    public PaymentRailMarkup? Markup { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("active")]
    public bool Active { get; init; }
}
