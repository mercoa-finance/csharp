using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record RepresentativeUpdateRequest
{
    [JsonPropertyName("name")]
    public FullName? Name { get; set; }

    [JsonPropertyName("phone")]
    public PhoneNumber? Phone { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("address")]
    public Address? Address { get; set; }

    [JsonPropertyName("birthDate")]
    public BirthDate? BirthDate { get; set; }

    [JsonPropertyName("governmentID")]
    public IndividualGovernmentId? GovernmentId { get; set; }

    [JsonPropertyName("responsibilities")]
    public Responsibilities? Responsibilities { get; set; }
}
