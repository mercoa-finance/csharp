using Mercoa.Client;

namespace Mercoa.Client.Entity;

public class GenerateOnboardingLink
{
    /// <summary>
    /// The type of onboarding link to generate. If not provided, the default is payee. The onboarding options are determined by your organization's onboarding configuration.
    /// </summary>
    public EntityOnboardingLinkType Type { get; init; }

    /// <summary>
    /// Expressed in seconds or a string describing a time span. The default is 24h.
    /// </summary>
    public string? ExpiresIn { get; init; }

    /// <summary>
    /// The ID of the entity to connect to. If onboarding a payee, this should be the payor entity ID. If onboarding a payor, this should be the payee entity ID. If no connected entity ID is provided, the onboarding link will be for a standalone entity.
    /// </summary>
    public string? ConnectedEntityId { get; init; }
}
