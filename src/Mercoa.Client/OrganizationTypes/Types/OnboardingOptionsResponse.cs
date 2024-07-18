using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record OnboardingOptionsResponse
{
    [JsonPropertyName("enableBusiness")]
    public required bool EnableBusiness { get; init; }

    [JsonPropertyName("enableIndividual")]
    public required bool EnableIndividual { get; init; }

    [JsonPropertyName("paymentMethod")]
    public required bool PaymentMethod { get; init; }

    [JsonPropertyName("business")]
    public required BusinessOnboardingOptions Business { get; init; }

    [JsonPropertyName("individual")]
    public required IndividualOnboardingOptions Individual { get; init; }
}
