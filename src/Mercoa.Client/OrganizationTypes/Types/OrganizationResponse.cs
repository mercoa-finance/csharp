using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record OrganizationResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("sandbox")]
    public required bool Sandbox { get; init; }

    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("logoUrl")]
    public string? LogoUrl { get; init; }

    [JsonPropertyName("websiteUrl")]
    public string? WebsiteUrl { get; init; }

    [JsonPropertyName("supportEmail")]
    public string? SupportEmail { get; init; }

    [JsonPropertyName("paymentMethods")]
    public PaymentMethodsResponse? PaymentMethods { get; init; }

    [JsonPropertyName("emailProvider")]
    public EmailProviderResponse? EmailProvider { get; init; }

    [JsonPropertyName("externalAccountingSystemProvider")]
    public object? ExternalAccountingSystemProvider { get; init; }

    [JsonPropertyName("colorScheme")]
    public ColorSchemeResponse? ColorScheme { get; init; }

    [JsonPropertyName("payeeOnboardingOptions")]
    public OnboardingOptionsResponse? PayeeOnboardingOptions { get; init; }

    [JsonPropertyName("payorOnboardingOptions")]
    public OnboardingOptionsResponse? PayorOnboardingOptions { get; init; }

    [JsonPropertyName("metadataSchema")]
    public IEnumerable<MetadataSchema>? MetadataSchema { get; init; }
}
