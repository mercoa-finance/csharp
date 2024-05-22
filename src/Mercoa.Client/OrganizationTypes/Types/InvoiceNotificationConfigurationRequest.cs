using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class InvoiceNotificationConfigurationRequest
{
    [JsonPropertyName("url")]
    public string Url { get; init; }
}
