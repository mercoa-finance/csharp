using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record FullName
{
    [JsonPropertyName("firstName")]
    public required string FirstName { get; init; }

    [JsonPropertyName("middleName")]
    public string? MiddleName { get; init; }

    [JsonPropertyName("lastName")]
    public required string LastName { get; init; }

    [JsonPropertyName("suffix")]
    public string? Suffix { get; init; }
}
