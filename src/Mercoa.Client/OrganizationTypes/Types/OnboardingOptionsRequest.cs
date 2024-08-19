using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record OnboardingOptionsRequest
{
    [JsonPropertyName("enableBusiness")]
    public bool? EnableBusiness { get; set; }

    [JsonPropertyName("enableIndividual")]
    public bool? EnableIndividual { get; set; }

    [JsonPropertyName("paymentMethod")]
    public bool? PaymentMethod { get; set; }

    [JsonPropertyName("business")]
    public BusinessOnboardingOptions? Business { get; set; }

    [JsonPropertyName("individual")]
    public IndividualOnboardingOptions? Individual { get; set; }
}
