using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EmailProviderResponse
{
    [JsonPropertyName("sender")]
    public required EmailSenderResponse Sender { get; set; }

    [JsonPropertyName("inboxDomain")]
    public required string InboxDomain { get; set; }
}
