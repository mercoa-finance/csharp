using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class EmailProviderRequest
{
    [JsonPropertyName("sender")]
    public EmailSenderRequest Sender { get; init; }

    [JsonPropertyName("inboxDomain")]
    public string InboxDomain { get; init; }
}
