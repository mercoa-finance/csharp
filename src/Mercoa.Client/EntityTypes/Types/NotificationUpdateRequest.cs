using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record NotificationUpdateRequest
{
    [JsonPropertyName("status")]
    public NotificationStatus? Status { get; init; }
}
