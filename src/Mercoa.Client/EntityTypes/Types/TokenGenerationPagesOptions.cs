using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class TokenGenerationPagesOptions
{
    [JsonPropertyName("paymentMethods")]
    public bool? PaymentMethods { get; init; }

    [JsonPropertyName("representatives")]
    public bool? Representatives { get; init; }

    [JsonPropertyName("notifications")]
    public bool? Notifications { get; init; }

    [JsonPropertyName("counterparties")]
    public bool? Counterparties { get; init; }

    [JsonPropertyName("approvals")]
    public bool? Approvals { get; init; }

    [JsonPropertyName("emailLog")]
    public bool? EmailLog { get; init; }
}
