namespace Mercoa.Client.Organization;

public record GetOrganizationRequest
{
    /// <summary>
    /// include supported payment methods in response
    /// </summary>
    public bool? PaymentMethods { get; set; }

    /// <summary>
    /// include email provider info in response
    /// </summary>
    public bool? EmailProvider { get; set; }

    /// <summary>
    /// include external accounting system provider info in response
    /// </summary>
    public bool? ExternalAccountingSystemProvider { get; set; }

    /// <summary>
    /// include color scheme info in response
    /// </summary>
    public bool? ColorScheme { get; set; }

    /// <summary>
    /// include payee onboarding options in response
    /// </summary>
    public bool? PayeeOnboardingOptions { get; set; }

    /// <summary>
    /// include payor onboarding options in response
    /// </summary>
    public bool? PayorOnboardingOptions { get; set; }

    /// <summary>
    /// include metadata schema in response
    /// </summary>
    public bool? MetadataSchema { get; set; }

    /// <summary>
    /// include notification-email-template in response
    /// </summary>
    public bool? NotificationEmailTemplate { get; set; }

    /// <summary>
    /// include custom domains in response
    /// </summary>
    public bool? CustomDomains { get; set; }
}
