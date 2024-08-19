using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityMetadataResponse
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    [JsonPropertyName("value")]
    public IEnumerable<string> Value { get; set; } = new List<string>();
}
