using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record IndividualOnboardingOptions
{
    [JsonPropertyName("termsOfService")]
    public required OnboardingOption TermsOfService { get; init; }

    [JsonPropertyName("email")]
    public required OnboardingOption Email { get; init; }

    [JsonPropertyName("name")]
    public required OnboardingOption Name { get; init; }

    [JsonPropertyName("dateOfBirth")]
    public required OnboardingOption DateOfBirth { get; init; }

    [JsonPropertyName("ssn")]
    public required OnboardingOption Ssn { get; init; }

    [JsonPropertyName("address")]
    public required OnboardingOption Address { get; init; }

    [JsonPropertyName("phone")]
    public required OnboardingOption Phone { get; init; }
}
