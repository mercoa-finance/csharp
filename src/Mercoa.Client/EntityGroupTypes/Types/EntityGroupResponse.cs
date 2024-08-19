using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record EntityGroupResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("emailToName")]
    public string? EmailToName { get; init; }

    [JsonPropertyName("entities")]
    public IEnumerable<EntityResponse> Entities { get; init; } = new List<EntityResponse>();
}
