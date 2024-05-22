using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class BusinessOnboardingOptions
{
    [JsonPropertyName("termsOfService")]
    public OnboardingOption TermsOfService { get; init; }

    [JsonPropertyName("email")]
    public OnboardingOption Email { get; init; }

    [JsonPropertyName("name")]
    public OnboardingOption Name { get; init; }

    [JsonPropertyName("type")]
    public OnboardingOption Type { get; init; }

    [JsonPropertyName("doingBusinessAs")]
    public OnboardingOption DoingBusinessAs { get; init; }

    [JsonPropertyName("ein")]
    public OnboardingOption Ein { get; init; }

    [JsonPropertyName("address")]
    public OnboardingOption Address { get; init; }

    [JsonPropertyName("phone")]
    public OnboardingOption Phone { get; init; }

    [JsonPropertyName("formationDate")]
    public OnboardingOption FormationDate { get; init; }

    [JsonPropertyName("website")]
    public OnboardingOption Website { get; init; }

    [JsonPropertyName("description")]
    public OnboardingOption Description { get; init; }

    [JsonPropertyName("representatives")]
    public OnboardingOption Representatives { get; init; }
}
