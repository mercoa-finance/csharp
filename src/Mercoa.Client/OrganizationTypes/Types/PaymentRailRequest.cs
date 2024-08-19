using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record PaymentRailRequest
{
    [JsonPropertyName("type")]
    public required PaymentMethodType Type { get; set; }

    /// <summary>
    /// For custom payment methods, this is the ID of the schema.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("active")]
    public required bool Active { get; set; }
}
