using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record RepresentativeRequest
{
    [JsonPropertyName("name")]
    public required FullName Name { get; set; }

    [JsonPropertyName("phone")]
    public required PhoneNumber Phone { get; set; }

    [JsonPropertyName("email")]
    public required string Email { get; set; }

    [JsonPropertyName("address")]
    public required Address Address { get; set; }

    [JsonPropertyName("birthDate")]
    public required BirthDate BirthDate { get; set; }

    [JsonPropertyName("governmentID")]
    public required IndividualGovernmentId GovernmentId { get; set; }

    [JsonPropertyName("responsibilities")]
    public required Responsibilities Responsibilities { get; set; }
}
