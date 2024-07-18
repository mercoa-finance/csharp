using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record EmailProviderResponse
{
    [JsonPropertyName("sender")]
    public required EmailSenderResponse Sender { get; init; }

    [JsonPropertyName("inboxDomain")]
    public required string InboxDomain { get; init; }
}
