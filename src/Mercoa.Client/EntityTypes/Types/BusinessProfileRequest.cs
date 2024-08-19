using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record BusinessProfileRequest
{
    /// <summary>
    /// Email address for the business. Required for KYB.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("legalBusinessName")]
    public required string LegalBusinessName { get; set; }

    [JsonPropertyName("businessType")]
    public BusinessType? BusinessType { get; set; }

    /// <summary>
    /// Phone number for the business. Required for KYB.
    /// </summary>
    [JsonPropertyName("phone")]
    public PhoneNumber? Phone { get; set; }

    [JsonPropertyName("doingBusinessAs")]
    public string? DoingBusinessAs { get; set; }

    /// <summary>
    /// Website URL for the business. Must be in the format http://www.example.com. Required for KYB if description is not provided.
    /// </summary>
    [JsonPropertyName("website")]
    public string? Website { get; set; }

    /// <summary>
    /// Description of the business. Required for KYB if website is not provided.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Address for the business. Required for KYB.
    /// </summary>
    [JsonPropertyName("address")]
    public Address? Address { get; set; }

    /// <summary>
    /// Tax ID for the business. Currently only EIN is supported. Required for KYB.
    /// </summary>
    [JsonPropertyName("taxId")]
    public TaxId? TaxId { get; set; }

    /// <summary>
    /// Date of business formation
    /// </summary>
    [JsonPropertyName("formationDate")]
    public DateTime? FormationDate { get; set; }

    /// <summary>
    /// Industry code for the business. Required to collect funds.
    /// </summary>
    [JsonPropertyName("industryCodes")]
    public IndustryCodes? IndustryCodes { get; set; }

    /// <summary>
    /// Average monthly transaction volume for the business. Required to collect funds.
    /// </summary>
    [JsonPropertyName("averageMonthlyTransactionVolume")]
    public double? AverageMonthlyTransactionVolume { get; set; }

    /// <summary>
    /// Average transaction size for the business. Required to collect funds.
    /// </summary>
    [JsonPropertyName("averageTransactionSize")]
    public double? AverageTransactionSize { get; set; }

    /// <summary>
    /// Maximum transaction size for the business. Required to collect funds.
    /// </summary>
    [JsonPropertyName("maxTransactionSize")]
    public double? MaxTransactionSize { get; set; }
}
