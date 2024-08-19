using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record IndividualProfileRequest
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("name")]
    public required FullName Name { get; set; }

    [JsonPropertyName("phone")]
    public PhoneNumber? Phone { get; set; }

    [JsonPropertyName("address")]
    public Address? Address { get; set; }

    [JsonPropertyName("birthDate")]
    public BirthDate? BirthDate { get; set; }

    [JsonPropertyName("governmentID")]
    public IndividualGovernmentId? GovernmentId { get; set; }
}
