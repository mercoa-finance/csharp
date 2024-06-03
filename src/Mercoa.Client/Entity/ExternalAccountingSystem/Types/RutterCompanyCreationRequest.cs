using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client.Entity;

public class RutterCompanyCreationRequest
{
    /// <summary>
    /// The access token for the existing Rutter connection. If the connection does not exist, leave this field blank and Rutter will create a new connection.
    /// </summary>
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; init; }
}
