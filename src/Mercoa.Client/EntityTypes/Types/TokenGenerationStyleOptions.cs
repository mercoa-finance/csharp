using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class TokenGenerationStyleOptions
{
    [JsonPropertyName("primaryColor")]
    public string PrimaryColor { get; init; }
}
