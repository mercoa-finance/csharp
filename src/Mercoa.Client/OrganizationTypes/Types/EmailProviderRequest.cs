using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EmailProviderRequest
{
    [JsonPropertyName("sender")]
    public required EmailSenderRequest Sender { get; set; }

    [JsonPropertyName("inboxDomain")]
    public required string InboxDomain { get; set; }

    [JsonPropertyName("alternativeInboxDomains")]
    public IEnumerable<string>? AlternativeInboxDomains { get; set; }
}
