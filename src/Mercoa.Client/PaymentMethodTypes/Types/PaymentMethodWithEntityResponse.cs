using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record PaymentMethodWithEntityResponse
{
    [JsonPropertyName("paymentMethod")]
    public required object PaymentMethod { get; init; }

    [JsonPropertyName("entity")]
    public required EntityResponse Entity { get; init; }
}
