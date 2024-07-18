using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record PlaidLinkRequest
{
    /// <summary>
    /// Plaid account ID
    /// </summary>
    [JsonPropertyName("accountId")]
    public required string AccountId { get; init; }

    /// <summary>
    /// Public token received from Plaid Link. Use this if linking the account using the Plaid Link frontend component.
    /// </summary>
    [JsonPropertyName("publicToken")]
    public string? PublicToken { get; init; }

    /// <summary>
    /// Plaid access token for the account. If you already have an access token for the account (for example, you have linked the account to your app already), use this instead of publicToken.
    /// </summary>
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; init; }
}
