using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceNotificationConfigurationRequest
{
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}
