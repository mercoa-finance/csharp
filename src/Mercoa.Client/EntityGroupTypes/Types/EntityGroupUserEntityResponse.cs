using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityGroupUserEntityResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// List of roles. A role can be any string. For example: "payer", "approver", "viewer"
    /// </summary>
    [JsonPropertyName("roles")]
    public IEnumerable<string> Roles { get; set; } = new List<string>();

    /// <summary>
    /// The IDs of the entities that these roles applies to.
    /// </summary>
    [JsonPropertyName("entityId")]
    public required string EntityId { get; set; }
}
