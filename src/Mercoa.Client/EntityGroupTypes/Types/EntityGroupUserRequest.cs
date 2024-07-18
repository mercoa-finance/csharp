using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record EntityGroupUserRequest
{
    /// <summary>
    /// The ID used to identify this user in your system. This is a required field and needs to be unique for all users in the group.
    /// </summary>
    [JsonPropertyName("foreignId")]
    public required string ForeignId { get; init; }

    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// List of roles per entity. By default, the user will have no roles.
    /// </summary>
    [JsonPropertyName("entities")]
    public IEnumerable<EntityGroupUserEntityRequest>? Entities { get; init; }
}
