using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CodatProviderResponse
{
    [JsonPropertyName("hasApiKey")]
    public required bool HasApiKey { get; init; }
}
