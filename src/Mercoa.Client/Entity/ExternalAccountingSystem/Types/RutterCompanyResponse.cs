using System.Text.Json.Serialization;

namespace Mercoa.Client.Entity;

public class RutterCompanyResponse
{
    [JsonPropertyName("accessToken")]
    public string AccessToken { get; init; }
}
