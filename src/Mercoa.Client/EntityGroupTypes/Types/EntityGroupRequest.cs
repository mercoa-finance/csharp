using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityGroupRequest
{
    [JsonPropertyName("entityIds")]
    public IEnumerable<string> EntityIds { get; init; } = new List<string>();
}
