using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class InvoiceNotificationConfigurationResponse
{
    [JsonPropertyName("type")]
    public NotificationType Type { get; init; }

    [JsonPropertyName("url")]
    public string Url { get; init; }
}
