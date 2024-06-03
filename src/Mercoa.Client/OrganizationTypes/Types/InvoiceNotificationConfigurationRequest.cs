using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class InvoiceNotificationConfigurationRequest
{
    [JsonPropertyName("url")]
    public string Url { get; init; }
}
