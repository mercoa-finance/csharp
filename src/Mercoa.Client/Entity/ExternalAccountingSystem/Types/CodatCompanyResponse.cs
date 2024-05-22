using System.Text.Json.Serialization;

namespace Mercoa.Client.Entity;

public class CodatCompanyResponse
{
    [JsonPropertyName("companyId")]
    public string CompanyId { get; init; }
}
