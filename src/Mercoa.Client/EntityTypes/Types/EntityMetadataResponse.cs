using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class EntityMetadataResponse
{
    [JsonPropertyName("key")]
    public string Key { get; init; }

    [JsonPropertyName("value")]
    public List<string> Value { get; init; }
}
