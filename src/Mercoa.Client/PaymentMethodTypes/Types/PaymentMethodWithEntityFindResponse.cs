using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record PaymentMethodWithEntityFindResponse
{
    [JsonPropertyName("count")]
    public required int Count { get; init; }

    [JsonPropertyName("hasMore")]
    public required bool HasMore { get; init; }

    [JsonPropertyName("data")]
    public IEnumerable<PaymentMethodWithEntityResponse> Data { get; init; } =
        new List<PaymentMethodWithEntityResponse>();
}
