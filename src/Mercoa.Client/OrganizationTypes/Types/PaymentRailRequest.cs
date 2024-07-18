using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record PaymentRailRequest
{
    [JsonPropertyName("type")]
    public required PaymentMethodType Type { get; init; }

    /// <summary>
    /// For custom payment methods, this is the ID of the schema.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("active")]
    public required bool Active { get; init; }
}
