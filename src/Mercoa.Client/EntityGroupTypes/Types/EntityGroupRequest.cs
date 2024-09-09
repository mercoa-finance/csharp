using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityGroupRequest
{
    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("emailToName")]
    public string? EmailToName { get; set; }

    /// <summary>
    /// Metadata key/value pairs to associate with this group. Will overwrite existing metadata.
    /// </summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// List of entity IDs or foreign IDs
    /// </summary>
    [JsonPropertyName("entityIds")]
    public IEnumerable<string>? EntityIds { get; set; }
}
