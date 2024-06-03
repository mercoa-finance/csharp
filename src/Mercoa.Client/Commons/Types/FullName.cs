using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class FullName
{
    [JsonPropertyName("firstName")]
    public string FirstName { get; init; }

    [JsonPropertyName("middleName")]
    public string? MiddleName { get; init; }

    [JsonPropertyName("lastName")]
    public string LastName { get; init; }

    [JsonPropertyName("suffix")]
    public string? Suffix { get; init; }
}
