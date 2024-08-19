using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record BusinessOnboardingOptions
{
    [JsonPropertyName("type")]
    public required OnboardingOption Type { get; init; }

    [JsonPropertyName("doingBusinessAs")]
    public required OnboardingOption DoingBusinessAs { get; init; }

    [JsonPropertyName("ein")]
    public required OnboardingOption Ein { get; init; }

    [JsonPropertyName("mcc")]
    public required OnboardingOption Mcc { get; init; }

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

    [JsonPropertyName("averageTransactionSize")]
    public required OnboardingOption AverageTransactionSize { get; init; }

    [JsonPropertyName("averageMonthlyTransactionVolume")]
    public required OnboardingOption AverageMonthlyTransactionVolume { get; init; }

    [JsonPropertyName("maxTransactionSize")]
    public required OnboardingOption MaxTransactionSize { get; init; }

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
