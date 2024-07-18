using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record InvoiceNotificationConfigurationResponse
{
    [JsonPropertyName("type")]
    public required NotificationType Type { get; init; }

    [JsonPropertyName("url")]
    public required string Url { get; init; }
}
