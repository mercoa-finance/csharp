using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record PlaidPublicTokenRequest
{
    /// <summary>
    /// Plaid account ID. If not provided, will try to match the provided routing number and account number.
    /// </summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>
    /// Public token received from Plaid Link. Use this if linking the account using the Plaid Link frontend component.
    /// </summary>
    [JsonPropertyName("publicToken")]
    public required string PublicToken { get; set; }
}
