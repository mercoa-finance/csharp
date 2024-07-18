using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityUserResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

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
    public IEnumerable<string> Roles { get; init; } = new List<string>();

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; init; }
}
