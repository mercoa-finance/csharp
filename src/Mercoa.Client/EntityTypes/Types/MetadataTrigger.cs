using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record MetadataTrigger
{
    /// <summary>
    /// The metadata key to match
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// The metadata value the invoice must have to trigger this policy
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}
