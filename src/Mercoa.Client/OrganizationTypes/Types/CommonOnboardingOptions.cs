using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CommonOnboardingOptions
{
    [JsonPropertyName("termsOfService")]
    public required OnboardingOption TermsOfService { get; set; }

    [JsonPropertyName("email")]
    public required OnboardingOption Email { get; set; }

    [JsonPropertyName("name")]
    public required OnboardingOption Name { get; set; }

    [JsonPropertyName("address")]
    public required OnboardingOption Address { get; set; }

    [JsonPropertyName("phone")]
    public required OnboardingOption Phone { get; set; }

    [JsonPropertyName("tenNinetyNine")]
    public required OnboardingOption TenNinetyNine { get; set; }

    [JsonPropertyName("w9")]
    public required OnboardingOption W9 { get; set; }
}