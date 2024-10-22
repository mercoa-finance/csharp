using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record NotificationEmailTemplateResponse
{
    [JsonPropertyName("backgroundStyle")]
    public string? BackgroundStyle { get; set; }

    [JsonPropertyName("header")]
    public string? Header { get; set; }

    [JsonPropertyName("body")]
    public string? Body { get; set; }

    [JsonPropertyName("signature")]
    public string? Signature { get; set; }

    [JsonPropertyName("footer")]
    public string? Footer { get; set; }

    [JsonPropertyName("button")]
    public string? Button { get; set; }
}
