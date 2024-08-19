using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record UtilityPaymentDestinationOptions
{
    /// <summary>
    /// The ID for the utility account to pay with. Links to accounts listed on payor/payee relationship.
    /// </summary>
    [JsonPropertyName("accountId")]
    public required string AccountId { get; set; }
}
