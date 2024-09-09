using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceEvent
{
    [JsonPropertyName("webhookIds")]
    public IEnumerable<string> WebhookIds { get; set; } = new List<string>();

    [JsonPropertyName("data")]
    public required InvoiceResponse Data { get; set; }

    /// <summary>
    /// The ID of the user who triggered this event
    /// </summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }
}
