using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record IndividualProfileResponse
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("name")]
    public required FullName Name { get; set; }

    [JsonPropertyName("phone")]
    public PhoneNumber? Phone { get; set; }

    [JsonPropertyName("address")]
    public Address? Address { get; set; }

    [JsonPropertyName("birthDateProvided")]
    public required bool BirthDateProvided { get; set; }

    [JsonPropertyName("governmentIDProvided")]
    public required bool GovernmentIdProvided { get; set; }
}
