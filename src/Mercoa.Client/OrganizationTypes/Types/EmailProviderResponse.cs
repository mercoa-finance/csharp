using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class EmailProviderResponse
{
    [JsonPropertyName("sender")]
    public EmailSenderResponse Sender { get; init; }

    [JsonPropertyName("inboxDomain")]
    public string InboxDomain { get; init; }
}
