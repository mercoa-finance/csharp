using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityUserRequest
{
    /// <summary>
    /// The ID used to identify this user in your system.
    /// </summary>
    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// List of roles. A role can be any string. For example: "payer", "approver", "viewer"
    /// </summary>
    [JsonPropertyName("roles")]
    public IEnumerable<string>? Roles { get; set; }
}
