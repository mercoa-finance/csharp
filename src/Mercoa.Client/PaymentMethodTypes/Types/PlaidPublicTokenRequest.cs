using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record PlaidPublicTokenRequest
{
    /// <summary>
    /// Plaid account ID
    /// </summary>
    [JsonPropertyName("accountId")]
    public required string AccountId { get; set; }

    /// <summary>
    /// Public token received from Plaid Link. Use this if linking the account using the Plaid Link frontend component.
    /// </summary>
    [JsonPropertyName("publicToken")]
    public required string PublicToken { get; set; }
}
