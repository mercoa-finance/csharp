using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record RepresentativeRequest
{
    [JsonPropertyName("name")]
    public required FullName Name { get; set; }

    /// <summary>
    /// Either phone or email is required.
    /// </summary>
    [JsonPropertyName("phone")]
    public PhoneNumber? Phone { get; set; }

    /// <summary>
    /// Either phone or email is required.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("address")]
    public required Address Address { get; set; }

    [JsonPropertyName("birthDate")]
    public required BirthDate BirthDate { get; set; }

    [JsonPropertyName("governmentID")]
    public required IndividualGovernmentId GovernmentId { get; set; }

    [JsonPropertyName("responsibilities")]
    public required Responsibilities Responsibilities { get; set; }
}
