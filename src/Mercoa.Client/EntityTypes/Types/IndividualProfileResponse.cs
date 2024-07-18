using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record IndividualProfileResponse
{
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("name")]
    public required FullName Name { get; init; }

    [JsonPropertyName("phone")]
    public PhoneNumber? Phone { get; init; }

    [JsonPropertyName("address")]
    public Address? Address { get; init; }

    [JsonPropertyName("birthDateProvided")]
    public required bool BirthDateProvided { get; init; }

    [JsonPropertyName("governmentIDProvided")]
    public required bool GovernmentIdProvided { get; init; }
}
