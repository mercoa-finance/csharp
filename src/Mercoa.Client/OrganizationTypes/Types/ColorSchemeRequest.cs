using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record ColorSchemeRequest
{
    [JsonPropertyName("primaryColor")]
    public string? PrimaryColor { get; set; }

    [JsonPropertyName("secondaryColor")]
    public string? SecondaryColor { get; set; }

    [JsonPropertyName("logoBackgroundColor")]
    public string? LogoBackgroundColor { get; set; }

    [JsonPropertyName("roundedCorners")]
    public int? RoundedCorners { get; set; }

    [JsonPropertyName("fontFamily")]
    public string? FontFamily { get; set; }

    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }
}
