using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client.Entity;

public class CodatCompanyResponse
{
    [JsonPropertyName("companyId")]
    public string CompanyId { get; init; }
}
