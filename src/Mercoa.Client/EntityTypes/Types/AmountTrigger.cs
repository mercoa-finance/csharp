using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record AmountTrigger
{
    [JsonPropertyName("amount")]
    public required double Amount { get; set; }

    [JsonPropertyName("currency")]
    public required CurrencyCode Currency { get; set; }
}
