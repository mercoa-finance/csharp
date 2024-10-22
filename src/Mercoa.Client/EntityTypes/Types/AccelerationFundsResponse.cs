using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record AccelerationFundsResponse
{
    /// <summary>
    /// The ID of the entity that these acceleration funds belong to.
    /// </summary>
    [JsonPropertyName("entityId")]
    public required string EntityId { get; set; }

    /// <summary>
    /// The ID of the payment method that the acceleration funds were accessed through.
    /// </summary>
    [JsonPropertyName("paymentMethodId")]
    public required string PaymentMethodId { get; set; }

    [JsonPropertyName("availableBalance")]
    public required AccelerationFundsBalanceResponse AvailableBalance { get; set; }

    [JsonPropertyName("pendingBalance")]
    public required AccelerationFundsBalanceResponse PendingBalance { get; set; }
}
