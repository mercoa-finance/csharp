using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class TokenGenerationStyleOptions
{
    [JsonPropertyName("primaryColor")]
    public string PrimaryColor { get; init; }
}
