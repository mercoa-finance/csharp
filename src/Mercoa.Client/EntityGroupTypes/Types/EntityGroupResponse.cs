using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class EntityGroupResponse
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("entities")]
    public IEnumerable<EntityResponse> Entities { get; init; }
}
