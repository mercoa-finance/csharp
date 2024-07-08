using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class EntityGroupFindResponse
{
    [JsonPropertyName("count")]
    public int Count { get; init; }

    [JsonPropertyName("hasMore")]
    public bool HasMore { get; init; }

    [JsonPropertyName("data")]
    public IEnumerable<EntityGroupResponse> Data { get; init; }
}
