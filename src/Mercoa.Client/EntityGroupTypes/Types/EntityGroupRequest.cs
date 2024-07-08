using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class EntityGroupRequest
{
    [JsonPropertyName("entityIds")]
    public IEnumerable<string> EntityIds { get; init; }
}
