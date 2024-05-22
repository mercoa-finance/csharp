using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class EntityUserResponse
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// The ID used to identify this user in your system.
    /// </summary>
    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; init; }

    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("roles")]
    public List<string> Roles { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }
}
