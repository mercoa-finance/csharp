using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record OnboardingOption
{
    [JsonPropertyName("show")]
    public required bool Show { get; set; }

    [JsonPropertyName("edit")]
    public required bool Edit { get; set; }

    [JsonPropertyName("required")]
    public required bool Required { get; set; }
}
