using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record EntityGroupResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("entities")]
    public IEnumerable<EntityResponse> Entities { get; init; } = new List<EntityResponse>();
}
