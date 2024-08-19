using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceNotificationConfigurationResponse
{
    [JsonPropertyName("type")]
    public required NotificationType Type { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}
