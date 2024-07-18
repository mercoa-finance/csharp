using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityMetadataResponse
{
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    [JsonPropertyName("value")]
    public IEnumerable<string> Value { get; init; } = new List<string>();
}
