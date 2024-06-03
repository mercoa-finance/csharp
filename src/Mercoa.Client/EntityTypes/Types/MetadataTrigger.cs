using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class MetadataTrigger
{
    /// <summary>
    /// The metadata key to match
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; init; }

    /// <summary>
    /// The metadata value the invoice must have to trigger this policy
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; init; }
}
