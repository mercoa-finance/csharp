using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class BusinessProfileRequest
{
    /// <summary>
    /// Email address for the business. Required for KYB.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("legalBusinessName")]
    public string LegalBusinessName { get; init; }

    [JsonPropertyName("businessType")]
    public BusinessType? BusinessType { get; init; }

    /// <summary>
    /// Phone number for the business. Required for KYB.
    /// </summary>
    [JsonPropertyName("phone")]
    public PhoneNumber? Phone { get; init; }

    [JsonPropertyName("doingBusinessAs")]
    public string? DoingBusinessAs { get; init; }

    /// <summary>
    /// Website URL for the business. Must be in the format http://www.example.com. Required for KYB if description is not provided.
    /// </summary>
    [JsonPropertyName("website")]
    public string? Website { get; init; }

    /// <summary>
    /// Description of the business. Required for KYB if website is not provided.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Address for the business. Required for KYB.
    /// </summary>
    [JsonPropertyName("address")]
    public Address? Address { get; init; }

    /// <summary>
    /// Tax ID for the business. Currently only EIN is supported. Required for KYB.
    /// </summary>
    [JsonPropertyName("taxId")]
    public TaxId? TaxId { get; init; }

    /// <summary>
    /// Date of business formation
    /// </summary>
    [JsonPropertyName("formationDate")]
    public DateTime? FormationDate { get; init; }
}
