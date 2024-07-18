using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record BusinessProfileResponse
{
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("legalBusinessName")]
    public required string LegalBusinessName { get; init; }

    [JsonPropertyName("businessType")]
    public BusinessType? BusinessType { get; init; }

    [JsonPropertyName("phone")]
    public PhoneNumber? Phone { get; init; }

    [JsonPropertyName("doingBusinessAs")]
    public string? DoingBusinessAs { get; init; }

    [JsonPropertyName("website")]
    public string? Website { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("address")]
    public Address? Address { get; init; }

    /// <summary>
    /// True if all representatives have been provided for this business.
    /// </summary>
    [JsonPropertyName("ownersProvided")]
    public bool? OwnersProvided { get; init; }

    [JsonPropertyName("taxIDProvided")]
    public required bool TaxIdProvided { get; init; }

    [JsonPropertyName("industryCodes")]
    public IndustryCodes? IndustryCodes { get; init; }
}
