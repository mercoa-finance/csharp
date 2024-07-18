using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record OnboardingOption
{
    [JsonPropertyName("show")]
    public required bool Show { get; init; }

    [JsonPropertyName("edit")]
    public required bool Edit { get; init; }

    [JsonPropertyName("required")]
    public required bool Required { get; init; }
}
