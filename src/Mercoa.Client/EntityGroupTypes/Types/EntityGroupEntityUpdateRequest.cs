using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityGroupEntityUpdateRequest
{
    /// <summary>
    /// List of entity IDs or foreign IDs
    /// </summary>
    [JsonPropertyName("entityIds")]
    public IEnumerable<string>? EntityIds { get; set; }
}
