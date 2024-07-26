using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record BusinessOnboardingOptions
{
    [JsonPropertyName("termsOfService")]
    public required OnboardingOption TermsOfService { get; init; }

    [JsonPropertyName("email")]
    public required OnboardingOption Email { get; init; }

    [JsonPropertyName("name")]
    public required OnboardingOption Name { get; init; }

    [JsonPropertyName("type")]
    public required OnboardingOption Type { get; init; }

    [JsonPropertyName("doingBusinessAs")]
    public required OnboardingOption DoingBusinessAs { get; init; }

    [JsonPropertyName("ein")]
    public required OnboardingOption Ein { get; init; }

    [JsonPropertyName("mcc")]
    public required OnboardingOption Mcc { get; init; }

    [JsonPropertyName("address")]
    public required OnboardingOption Address { get; init; }

    [JsonPropertyName("phone")]
    public required OnboardingOption Phone { get; init; }

    [JsonPropertyName("formationDate")]
    public required OnboardingOption FormationDate { get; init; }

    [JsonPropertyName("website")]
    public required OnboardingOption Website { get; init; }

    [JsonPropertyName("description")]
    public required OnboardingOption Description { get; init; }

    [JsonPropertyName("representatives")]
    public required OnboardingOption Representatives { get; init; }

    [JsonPropertyName("logo")]
    public required OnboardingOption Logo { get; init; }
}
