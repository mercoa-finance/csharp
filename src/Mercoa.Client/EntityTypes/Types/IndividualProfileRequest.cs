using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record IndividualProfileRequest
{
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("name")]
    public required FullName Name { get; init; }

    [JsonPropertyName("phone")]
    public PhoneNumber? Phone { get; init; }

    [JsonPropertyName("address")]
    public Address? Address { get; init; }

    [JsonPropertyName("birthDate")]
    public BirthDate? BirthDate { get; init; }

    [JsonPropertyName("governmentID")]
    public IndividualGovernmentId? GovernmentId { get; init; }
}
