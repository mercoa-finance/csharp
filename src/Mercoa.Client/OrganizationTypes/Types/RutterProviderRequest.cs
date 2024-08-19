using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record RutterProviderRequest
{
    [JsonPropertyName("clientId")]
    public required string ClientId { get; set; }

    [JsonPropertyName("clientSecret")]
    public required string ClientSecret { get; set; }
}
