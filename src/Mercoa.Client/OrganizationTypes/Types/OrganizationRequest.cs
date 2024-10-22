using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record OrganizationRequest
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("logo")]
    public string? Logo { get; set; }

    [JsonPropertyName("websiteUrl")]
    public string? WebsiteUrl { get; set; }

    [JsonPropertyName("supportEmail")]
    public string? SupportEmail { get; set; }

    [JsonPropertyName("paymentMethods")]
    public PaymentMethodsRequest? PaymentMethods { get; set; }

    [JsonPropertyName("emailProvider")]
    public EmailProviderRequest? EmailProvider { get; set; }

    [JsonPropertyName("externalAccountingSystemProvider")]
    public object? ExternalAccountingSystemProvider { get; set; }

    [JsonPropertyName("colorScheme")]
    public ColorSchemeRequest? ColorScheme { get; set; }

    [JsonPropertyName("payeeOnboardingOptions")]
    public OnboardingOptionsRequest? PayeeOnboardingOptions { get; set; }

    [JsonPropertyName("payorOnboardingOptions")]
    public OnboardingOptionsRequest? PayorOnboardingOptions { get; set; }

    [JsonPropertyName("metadataSchema")]
    public IEnumerable<MetadataSchema>? MetadataSchema { get; set; }

    [JsonPropertyName("notificationEmailTemplate")]
    public NotificationEmailTemplateRequest? NotificationEmailTemplate { get; set; }
}
