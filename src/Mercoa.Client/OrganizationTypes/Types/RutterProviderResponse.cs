using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record RutterProviderResponse
{
    [JsonPropertyName("hasClientId")]
    public required bool HasClientId { get; set; }

    [JsonPropertyName("hasClientSecret")]
    public required bool HasClientSecret { get; set; }
}
