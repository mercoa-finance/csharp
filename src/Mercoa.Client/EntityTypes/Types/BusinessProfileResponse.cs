using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record BusinessProfileResponse
{
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("legalBusinessName")]
    public required string LegalBusinessName { get; set; }

    [JsonPropertyName("businessType")]
    public BusinessType? BusinessType { get; set; }

    [JsonPropertyName("phone")]
    public PhoneNumber? Phone { get; set; }

    [JsonPropertyName("doingBusinessAs")]
    public string? DoingBusinessAs { get; set; }

    [JsonPropertyName("website")]
    public string? Website { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("address")]
    public Address? Address { get; set; }

    /// <summary>
    /// True if all representatives have been provided for this business.
    /// </summary>
    [JsonPropertyName("ownersProvided")]
    public bool? OwnersProvided { get; set; }

    [JsonPropertyName("taxIDProvided")]
    public required bool TaxIdProvided { get; set; }

    [JsonPropertyName("industryCodes")]
    public IndustryCodes? IndustryCodes { get; set; }

    [JsonPropertyName("averageMonthlyTransactionVolume")]
    public double? AverageMonthlyTransactionVolume { get; set; }

    [JsonPropertyName("averageTransactionSize")]
    public double? AverageTransactionSize { get; set; }

    [JsonPropertyName("maxTransactionSize")]
    public double? MaxTransactionSize { get; set; }
}
