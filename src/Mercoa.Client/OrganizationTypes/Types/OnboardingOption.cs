using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class OnboardingOption
{
    [JsonPropertyName("show")]
    public bool Show { get; init; }

    [JsonPropertyName("edit")]
    public bool Edit { get; init; }

    [JsonPropertyName("required")]
    public bool Required { get; init; }
}
