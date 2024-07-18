using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record EmailProviderRequest
{
    [JsonPropertyName("sender")]
    public required EmailSenderRequest Sender { get; init; }

    [JsonPropertyName("inboxDomain")]
    public required string InboxDomain { get; init; }
}
