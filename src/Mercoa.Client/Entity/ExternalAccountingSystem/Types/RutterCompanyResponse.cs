using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client.Entity;

public record RutterCompanyResponse
{
    [JsonPropertyName("accessToken")]
    public required string AccessToken { get; init; }
}
