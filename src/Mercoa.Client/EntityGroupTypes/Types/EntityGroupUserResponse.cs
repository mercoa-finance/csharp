using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityGroupUserResponse
{
    /// <summary>
    /// The ID used to identify this user in your system.
    /// </summary>
    [JsonPropertyName("foreignId")]
    public required string ForeignId { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// List of roles per entity.
    /// </summary>
    [JsonPropertyName("entities")]
    public IEnumerable<EntityGroupUserEntityResponse> Entities { get; set; } =
        new List<EntityGroupUserEntityResponse>();

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }
}
