using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record OrganizationResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("sandbox")]
    public required bool Sandbox { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("logoUrl")]
    public string? LogoUrl { get; set; }

    [JsonPropertyName("websiteUrl")]
    public string? WebsiteUrl { get; set; }

    [JsonPropertyName("supportEmail")]
    public string? SupportEmail { get; set; }

    [JsonPropertyName("paymentMethods")]
    public PaymentMethodsResponse? PaymentMethods { get; set; }

    [JsonPropertyName("emailProvider")]
    public EmailProviderResponse? EmailProvider { get; set; }

    [JsonPropertyName("externalAccountingSystemProvider")]
    public object? ExternalAccountingSystemProvider { get; set; }

    [JsonPropertyName("colorScheme")]
    public ColorSchemeResponse? ColorScheme { get; set; }

    [JsonPropertyName("payeeOnboardingOptions")]
    public OnboardingOptionsResponse? PayeeOnboardingOptions { get; set; }

    [JsonPropertyName("payorOnboardingOptions")]
    public OnboardingOptionsResponse? PayorOnboardingOptions { get; set; }

    [JsonPropertyName("metadataSchema")]
    public IEnumerable<MetadataSchema>? MetadataSchema { get; set; }

    [JsonPropertyName("notificationEmailTemplate")]
    public NotificationEmailTemplateResponse? NotificationEmailTemplate { get; set; }
}
