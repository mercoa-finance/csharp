using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client.Entity;

public class RutterCompanyResponse
{
    [JsonPropertyName("accessToken")]
    public string AccessToken { get; init; }
}
