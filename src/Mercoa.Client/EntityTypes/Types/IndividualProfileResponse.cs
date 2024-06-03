using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class IndividualProfileResponse
{
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("name")]
    public FullName Name { get; init; }

    [JsonPropertyName("phone")]
    public PhoneNumber? Phone { get; init; }

    [JsonPropertyName("address")]
    public Address? Address { get; init; }

    [JsonPropertyName("birthDateProvided")]
    public bool BirthDateProvided { get; init; }

    [JsonPropertyName("governmentIDProvided")]
    public bool GovernmentIdProvided { get; init; }
}
