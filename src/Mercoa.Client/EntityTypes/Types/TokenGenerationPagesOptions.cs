using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record TokenGenerationPagesOptions
{
    [JsonPropertyName("paymentMethods")]
    public bool? PaymentMethods { get; set; }

    [JsonPropertyName("representatives")]
    public bool? Representatives { get; set; }

    [JsonPropertyName("notifications")]
    public bool? Notifications { get; set; }

    [JsonPropertyName("counterparties")]
    public bool? Counterparties { get; set; }

    [JsonPropertyName("approvals")]
    public bool? Approvals { get; set; }

    [JsonPropertyName("emailLog")]
    public bool? EmailLog { get; set; }
}
