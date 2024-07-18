using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record CustomPaymentMethodSchemaFee
{
    [JsonPropertyName("type")]
    public required CustomPaymentMethodFeeType Type { get; init; }

    /// <summary>
    /// If type is 'flat', this is the flat amount that will be charged as a fee. For example, if the fee is $2.50, set this to 2.50. If type is 'percentage', this is the percentage of the payment amount that will be charged as a fee. For example, if the fee is 2.5%, set this to 2.5.
    /// </summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; init; }
}
