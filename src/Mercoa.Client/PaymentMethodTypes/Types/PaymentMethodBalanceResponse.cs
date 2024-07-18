using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record PaymentMethodBalanceResponse
{
    [JsonPropertyName("availableBalance")]
    public required double AvailableBalance { get; init; }

    [JsonPropertyName("currency")]
    public required CurrencyCode Currency { get; init; }

    /// <summary>
    /// If the status is UNAVAILABLE, the account does not support this operation. If the status is ERROR, the account may need to be re-linked with Plaid.
    /// </summary>
    [JsonPropertyName("status")]
    public required PaymentMethodBalanceStatus Status { get; init; }

    /// <summary>
    /// The time the balance was last updated. Will be null if the balance has never been updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; init; }
}
