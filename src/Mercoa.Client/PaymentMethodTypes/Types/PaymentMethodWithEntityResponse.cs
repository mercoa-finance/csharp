using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record PaymentMethodWithEntityResponse
{
    [JsonPropertyName("paymentMethod")]
    public required object PaymentMethod { get; set; }

    [JsonPropertyName("entity")]
    public required EntityResponse Entity { get; set; }
}
