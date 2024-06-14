using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class ColorSchemeRequest
{
    [JsonPropertyName("primaryColor")]
    public string? PrimaryColor { get; init; }

    [JsonPropertyName("secondaryColor")]
    public string? SecondaryColor { get; init; }

    [JsonPropertyName("logoBackgroundColor")]
    public string? LogoBackgroundColor { get; init; }

    [JsonPropertyName("roundedCorners")]
    public int? RoundedCorners { get; init; }
}
