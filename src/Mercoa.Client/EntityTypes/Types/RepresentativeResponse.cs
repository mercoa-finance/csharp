using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record RepresentativeResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("name")]
    public required FullName Name { get; init; }

    [JsonPropertyName("phone")]
    public required PhoneNumber Phone { get; init; }

    [JsonPropertyName("email")]
    public required string Email { get; init; }

    [JsonPropertyName("address")]
    public required Address Address { get; init; }

    [JsonPropertyName("birthDateProvided")]
    public required bool BirthDateProvided { get; init; }

    [JsonPropertyName("governmentIDProvided")]
    public required bool GovernmentIdProvided { get; init; }

    [JsonPropertyName("responsibilities")]
    public required Responsibilities Responsibilities { get; init; }

    [JsonPropertyName("createdOn")]
    public required DateTime CreatedOn { get; init; }

    [JsonPropertyName("updatedOn")]
    public required DateTime UpdatedOn { get; init; }

    [JsonPropertyName("disabledOn")]
    public DateTime? DisabledOn { get; init; }
}
