using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class EntityUserRequest
{
    /// <summary>
    /// The ID used to identify this user in your system.
    /// </summary>
    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; init; }

    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// List of roles. A role can be any string. For example: "payer", "approver", "viewer"
    /// </summary>
    [JsonPropertyName("roles")]
    public IEnumerable<string>? Roles { get; init; }
}
