using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class RutterProviderResponse
{
    [JsonPropertyName("hasClientId")]
    public bool HasClientId { get; init; }

    [JsonPropertyName("hasClientSecret")]
    public bool HasClientSecret { get; init; }
}
