using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityGroupUserEntityRequest
{
    /// <summary>
    /// List of roles. A role can be any string. For example: "payer", "approver", "viewer"
    /// </summary>
    [JsonPropertyName("roles")]
    public IEnumerable<string> Roles { get; init; } = new List<string>();

    /// <summary>
    /// The IDs of the entities that these roles applies to.
    /// </summary>
    [JsonPropertyName("entityId")]
    public required string EntityId { get; init; }
}
