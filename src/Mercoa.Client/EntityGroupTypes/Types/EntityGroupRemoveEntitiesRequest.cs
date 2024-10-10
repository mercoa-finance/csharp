using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityGroupRemoveEntitiesRequest
{
    /// <summary>
    /// List of entity IDs or foreign IDs to remove from the group
    /// </summary>
    [JsonPropertyName("entityIds")]
    public IEnumerable<string> EntityIds { get; set; } = new List<string>();
}
