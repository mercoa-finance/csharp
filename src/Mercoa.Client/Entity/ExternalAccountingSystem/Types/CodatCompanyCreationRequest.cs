using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client.Entity;

public class CodatCompanyCreationRequest
{
    /// <summary>
    /// If the company already exists in Codat, provide the company ID to link the company to the entity. If the company does not exist, leave this field blank and Codat will create a new company.
    /// </summary>
    [JsonPropertyName("companyId")]
    public string? CompanyId { get; init; }
}
