using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityGroupRequest
{
    [JsonPropertyName("entityIds")]
    public IEnumerable<string> EntityIds { get; init; } = new List<string>();

    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("emailToName")]
    public string? EmailToName { get; init; }
}
