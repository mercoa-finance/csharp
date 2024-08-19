using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record FullName
{
    [JsonPropertyName("firstName")]
    public required string FirstName { get; set; }

    [JsonPropertyName("middleName")]
    public string? MiddleName { get; set; }

    [JsonPropertyName("lastName")]
    public required string LastName { get; set; }

    [JsonPropertyName("suffix")]
    public string? Suffix { get; set; }
}
