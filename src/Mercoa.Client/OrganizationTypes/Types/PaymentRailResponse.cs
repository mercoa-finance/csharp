using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class PaymentRailResponse
{
    [JsonPropertyName("type")]
    public PaymentMethodType Type { get; init; }

    /// <summary>
    /// For custom payment methods, this is the ID of the schema.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("active")]
    public bool Active { get; init; }

    /// <summary>
    /// unused
    /// </summary>
    [JsonPropertyName("available")]
    public bool? Available { get; init; }
}
