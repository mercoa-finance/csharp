using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class CodatProviderResponse
{
    [JsonPropertyName("hasApiKey")]
    public bool HasApiKey { get; init; }
}
