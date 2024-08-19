using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record PaymentMethodBalanceResponse
{
    [JsonPropertyName("availableBalance")]
    public required double AvailableBalance { get; set; }

    [JsonPropertyName("currency")]
    public required CurrencyCode Currency { get; set; }

    /// <summary>
    /// If the status is UNAVAILABLE, the account does not support this operation. If the status is ERROR, the account may need to be re-linked with Plaid.
    /// </summary>
    [JsonPropertyName("status")]
    public required PaymentMethodBalanceStatus Status { get; set; }

    /// <summary>
    /// The time the balance was last updated. Will be null if the balance has never been updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
}
