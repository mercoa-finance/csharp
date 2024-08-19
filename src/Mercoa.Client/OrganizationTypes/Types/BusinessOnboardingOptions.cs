using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record BusinessOnboardingOptions
{
    [JsonPropertyName("type")]
    public required OnboardingOption Type { get; set; }

    [JsonPropertyName("doingBusinessAs")]
    public required OnboardingOption DoingBusinessAs { get; set; }

    [JsonPropertyName("ein")]
    public required OnboardingOption Ein { get; set; }

    [JsonPropertyName("mcc")]
    public required OnboardingOption Mcc { get; set; }

    [JsonPropertyName("formationDate")]
    public required OnboardingOption FormationDate { get; set; }

    [JsonPropertyName("website")]
    public required OnboardingOption Website { get; set; }

    [JsonPropertyName("description")]
    public required OnboardingOption Description { get; set; }

    [JsonPropertyName("representatives")]
    public required OnboardingOption Representatives { get; set; }

    [JsonPropertyName("logo")]
    public required OnboardingOption Logo { get; set; }

    [JsonPropertyName("averageTransactionSize")]
    public required OnboardingOption AverageTransactionSize { get; set; }

    [JsonPropertyName("averageMonthlyTransactionVolume")]
    public required OnboardingOption AverageMonthlyTransactionVolume { get; set; }

    [JsonPropertyName("maxTransactionSize")]
    public required OnboardingOption MaxTransactionSize { get; set; }

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
