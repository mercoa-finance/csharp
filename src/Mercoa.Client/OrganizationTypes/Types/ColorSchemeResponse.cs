using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class ColorSchemeResponse
{
    [JsonPropertyName("primaryColor")]
    public string? PrimaryColor { get; init; }

    [JsonPropertyName("secondaryColor")]
    public string? SecondaryColor { get; init; }

    [JsonPropertyName("logoBackgroundColor")]
    public string? LogoBackgroundColor { get; init; }
}
