using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record CommonOnboardingOptions
{
    [JsonPropertyName("termsOfService")]
    public required OnboardingOption TermsOfService { get; init; }

    [JsonPropertyName("email")]
    public required OnboardingOption Email { get; init; }

    [JsonPropertyName("name")]
    public required OnboardingOption Name { get; init; }

    [JsonPropertyName("address")]
    public required OnboardingOption Address { get; init; }

    [JsonPropertyName("phone")]
    public required OnboardingOption Phone { get; init; }

    [JsonPropertyName("tenNinetyNine")]
    public required OnboardingOption TenNinetyNine { get; init; }

    [JsonPropertyName("w9")]
    public required OnboardingOption W9 { get; init; }
}
