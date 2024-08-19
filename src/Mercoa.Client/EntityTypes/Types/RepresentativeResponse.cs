using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record RepresentativeResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required FullName Name { get; set; }

    [JsonPropertyName("phone")]
    public required PhoneNumber Phone { get; set; }

    [JsonPropertyName("email")]
    public required string Email { get; set; }

    [JsonPropertyName("address")]
    public required Address Address { get; set; }

    [JsonPropertyName("birthDateProvided")]
    public required bool BirthDateProvided { get; set; }

    [JsonPropertyName("governmentIDProvided")]
    public required bool GovernmentIdProvided { get; set; }

    [JsonPropertyName("responsibilities")]
    public required Responsibilities Responsibilities { get; set; }

    [JsonPropertyName("createdOn")]
    public required DateTime CreatedOn { get; set; }

    [JsonPropertyName("updatedOn")]
    public required DateTime UpdatedOn { get; set; }

    [JsonPropertyName("disabledOn")]
    public DateTime? DisabledOn { get; set; }
}
