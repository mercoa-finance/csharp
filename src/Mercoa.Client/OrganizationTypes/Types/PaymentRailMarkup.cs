using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class PaymentRailMarkup
{
    [JsonPropertyName("type")]
    public PaymentRailMarkupType Type { get; init; }

    [JsonPropertyName("amount")]
    public double Amount { get; init; }
}
