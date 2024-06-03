using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class TokenGenerationEntityOptions
{
    /// <summary>
    /// If true, will require entity to undergo KYB to use Mercoa payment rails and will capture required KYB data in the portal.
    /// </summary>
    [JsonPropertyName("enableMercoaPayments")]
    public bool? EnableMercoaPayments { get; init; }
}
