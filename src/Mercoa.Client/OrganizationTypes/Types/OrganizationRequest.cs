using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class OrganizationRequest
{
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("logo")]
    public string? Logo { get; init; }

    [JsonPropertyName("websiteUrl")]
    public string? WebsiteUrl { get; init; }

    [JsonPropertyName("supportEmail")]
    public string? SupportEmail { get; init; }

    [JsonPropertyName("paymentMethods")]
    public PaymentMethodsRequest? PaymentMethods { get; init; }

    [JsonPropertyName("emailProvider")]
    public EmailProviderRequest? EmailProvider { get; init; }

    [JsonPropertyName("externalAccountingSystemProvider")]
    public ExternalAccountingSystemProviderRequest? ExternalAccountingSystemProvider { get; init; }

    [JsonPropertyName("colorScheme")]
    public ColorSchemeRequest? ColorScheme { get; init; }

    [JsonPropertyName("payeeOnboardingOptions")]
    public OnboardingOptionsRequest? PayeeOnboardingOptions { get; init; }

    [JsonPropertyName("payorOnboardingOptions")]
    public OnboardingOptionsRequest? PayorOnboardingOptions { get; init; }

    [JsonPropertyName("metadataSchema")]
    public List<MetadataSchema>? MetadataSchema { get; init; }
}
