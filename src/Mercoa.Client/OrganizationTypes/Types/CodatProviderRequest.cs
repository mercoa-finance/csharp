using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class CodatProviderRequest
{
    [JsonPropertyName("apiKey")]
    public string ApiKey { get; init; }
}
