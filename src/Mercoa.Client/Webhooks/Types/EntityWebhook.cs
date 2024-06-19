using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class EntityWebhook
{
    [JsonPropertyName("eventType")]
    public string EventType { get; init; }

    [JsonPropertyName("entity")]
    public EntityResponse Entity { get; init; }
}
