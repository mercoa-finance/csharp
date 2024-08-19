using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record DocumentResponse
{
    /// <summary>
    /// ID of the document. If not provided, this is a dynamic document that is generated on the fly.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("mimeType")]
    public required string MimeType { get; set; }

    [JsonPropertyName("type")]
    public required DocumentType Type { get; set; }

    [JsonPropertyName("uri")]
    public required string Uri { get; set; }
}
