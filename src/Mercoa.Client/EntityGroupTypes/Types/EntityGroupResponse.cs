using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityGroupResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("emailToName")]
    public string? EmailToName { get; set; }

    [JsonPropertyName("entities")]
    public IEnumerable<EntityResponse> Entities { get; set; } = new List<EntityResponse>();

    [JsonPropertyName("metadata")]
    public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();
}
