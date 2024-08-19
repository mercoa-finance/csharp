using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record OnboardingOptionsResponse
{
    [JsonPropertyName("enableBusiness")]
    public required bool EnableBusiness { get; set; }

    [JsonPropertyName("enableIndividual")]
    public required bool EnableIndividual { get; set; }

    [JsonPropertyName("paymentMethod")]
    public required bool PaymentMethod { get; set; }

    [JsonPropertyName("business")]
    public required BusinessOnboardingOptions Business { get; set; }

    [JsonPropertyName("individual")]
    public required IndividualOnboardingOptions Individual { get; set; }
}
