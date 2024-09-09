using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityEventsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<EntityEvent> Data { get; set; } = new List<EntityEvent>();

    [JsonPropertyName("count")]
    public required int Count { get; set; }
}
