using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record TokenGenerationStyleOptions
{
    [JsonPropertyName("primaryColor")]
    public required string PrimaryColor { get; init; }
}
