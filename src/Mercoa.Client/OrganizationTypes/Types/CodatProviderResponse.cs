using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class CodatProviderResponse
{
    [JsonPropertyName("hasApiKey")]
    public bool HasApiKey { get; init; }
}
