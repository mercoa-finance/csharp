using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class RepresentativeResponse
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("name")]
    public FullName Name { get; init; }

    [JsonPropertyName("phone")]
    public PhoneNumber Phone { get; init; }

    [JsonPropertyName("email")]
    public string Email { get; init; }

    [JsonPropertyName("address")]
    public Address Address { get; init; }

    [JsonPropertyName("birthDateProvided")]
    public bool BirthDateProvided { get; init; }

    [JsonPropertyName("governmentIDProvided")]
    public bool GovernmentIdProvided { get; init; }

    [JsonPropertyName("responsibilities")]
    public Responsibilities Responsibilities { get; init; }

    [JsonPropertyName("createdOn")]
    public DateTime CreatedOn { get; init; }

    [JsonPropertyName("updatedOn")]
    public DateTime UpdatedOn { get; init; }

    [JsonPropertyName("disabledOn")]
    public DateTime? DisabledOn { get; init; }
}
