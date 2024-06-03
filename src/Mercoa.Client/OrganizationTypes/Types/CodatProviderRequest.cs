using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class CodatProviderRequest
{
    [JsonPropertyName("apiKey")]
    public string ApiKey { get; init; }
}
