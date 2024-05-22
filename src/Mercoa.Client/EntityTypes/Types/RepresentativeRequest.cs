using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class RepresentativeRequest
{
    [JsonPropertyName("name")]
    public FullName Name { get; init; }

    [JsonPropertyName("phone")]
    public PhoneNumber Phone { get; init; }

    [JsonPropertyName("email")]
    public string Email { get; init; }

    [JsonPropertyName("address")]
    public Address Address { get; init; }

    [JsonPropertyName("birthDate")]
    public BirthDate BirthDate { get; init; }

    [JsonPropertyName("governmentID")]
    public IndividualGovernmentId GovernmentId { get; init; }

    [JsonPropertyName("responsibilities")]
    public Responsibilities Responsibilities { get; init; }
}
