using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class RutterProviderRequest
{
    [JsonPropertyName("clientId")]
    public string ClientId { get; init; }

    [JsonPropertyName("clientSecret")]
    public string ClientSecret { get; init; }
}
