using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record RepresentativeRequest
{
    [JsonPropertyName("name")]
    public required FullName Name { get; init; }

    [JsonPropertyName("phone")]
    public required PhoneNumber Phone { get; init; }

    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("address")]
    public required Address Address { get; init; }

    [JsonPropertyName("birthDate")]
    public required BirthDate BirthDate { get; init; }

    [JsonPropertyName("governmentID")]
    public required IndividualGovernmentId GovernmentId { get; init; }

    [JsonPropertyName("responsibilities")]
    public required Responsibilities Responsibilities { get; init; }
}
