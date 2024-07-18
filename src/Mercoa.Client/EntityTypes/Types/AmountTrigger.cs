using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record AmountTrigger
{
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    [JsonPropertyName("currency")]
    public required CurrencyCode Currency { get; init; }
}
