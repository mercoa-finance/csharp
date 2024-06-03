using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class IndividualOnboardingOptions
{
    [JsonPropertyName("termsOfService")]
    public OnboardingOption TermsOfService { get; init; }

    [JsonPropertyName("email")]
    public OnboardingOption Email { get; init; }

    [JsonPropertyName("name")]
    public OnboardingOption Name { get; init; }

    [JsonPropertyName("dateOfBirth")]
    public OnboardingOption DateOfBirth { get; init; }

    [JsonPropertyName("ssn")]
    public OnboardingOption Ssn { get; init; }

    [JsonPropertyName("address")]
    public OnboardingOption Address { get; init; }

    [JsonPropertyName("phone")]
    public OnboardingOption Phone { get; init; }
}
