using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class EntityMetadataResponse
{
    [JsonPropertyName("key")]
    public string Key { get; init; }

    [JsonPropertyName("value")]
    public IEnumerable<string> Value { get; init; }
}
