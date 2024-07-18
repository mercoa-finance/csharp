namespace Mercoa.Client.Organization;

public record GetOrganizationRequest
{
    /// <summary>
    /// include supported payment methods in response
    /// </summary>
    public bool? PaymentMethods { get; init; }

    /// <summary>
    /// include email provider info in response
    /// </summary>
    public bool? EmailProvider { get; init; }

    /// <summary>
    /// include external accounting system provider info in response
    /// </summary>
    public bool? ExternalAccountingSystemProvider { get; init; }

    /// <summary>
    /// include color scheme info in response
    /// </summary>
    public bool? ColorScheme { get; init; }

    /// <summary>
    /// include payee onboarding options in response
    /// </summary>
    public bool? PayeeOnboardingOptions { get; init; }

    /// <summary>
    /// include payor onboarding options in response
    /// </summary>
    public bool? PayorOnboardingOptions { get; init; }

    /// <summary>
    /// include metadata schema in response
    /// </summary>
    public bool? MetadataSchema { get; init; }
}
