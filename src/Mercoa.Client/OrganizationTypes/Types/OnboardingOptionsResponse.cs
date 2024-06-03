using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class OnboardingOptionsResponse
{
    [JsonPropertyName("enableBusiness")]
    public bool EnableBusiness { get; init; }

    [JsonPropertyName("enableIndividual")]
    public bool EnableIndividual { get; init; }

    [JsonPropertyName("paymentMethod")]
    public bool PaymentMethod { get; init; }

    [JsonPropertyName("business")]
    public BusinessOnboardingOptions Business { get; init; }

    [JsonPropertyName("individual")]
    public IndividualOnboardingOptions Individual { get; init; }
}
