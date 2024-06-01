using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class PaymentRailRequest
{
    [JsonPropertyName("type")]
    public PaymentMethodType Type { get; init; }

    /// <summary>
    /// For custom payment methods, this is the ID of the schema.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("active")]
    public bool Active { get; init; }
}
