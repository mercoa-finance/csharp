using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record NotificationUpdateRequest
{
    [JsonPropertyName("status")]
    public NotificationStatus? Status { get; set; }
}
