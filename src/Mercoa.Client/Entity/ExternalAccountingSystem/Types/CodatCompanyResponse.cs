using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client.Entity;

public record CodatCompanyResponse
{
    [JsonPropertyName("companyId")]
    public required string CompanyId { get; init; }
}
