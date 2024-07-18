using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CodatProviderRequest
{
    [JsonPropertyName("apiKey")]
    public required string ApiKey { get; init; }
}
