using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class AmountTrigger
{
    [JsonPropertyName("amount")]
    public double Amount { get; init; }

    [JsonPropertyName("currency")]
    public CurrencyCode Currency { get; init; }
}
