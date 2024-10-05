using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record PlaidAccessTokenRequest
{
    /// <summary>
    /// Plaid account ID
    /// </summary>
    [JsonPropertyName("accountId")]
    public required string AccountId { get; set; }

    /// <summary>
    /// Plaid access token for the account. If you already have an access token for the account (for example, you have linked the account to your app already), use this instead of publicToken.
    /// </summary>
    [JsonPropertyName("accessToken")]
    public required string AccessToken { get; set; }
}
