using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityUserResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The ID used to identify this user in your system.
    /// </summary>
    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("roles")]
    public IEnumerable<string> Roles { get; set; } = new List<string>();

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }
}
