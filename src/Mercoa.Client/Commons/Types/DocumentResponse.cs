using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record DocumentResponse
{
    /// <summary>
    /// ID of the document. If not provided, this is a dynamic document that is generated on the fly.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("mimeType")]
    public required string MimeType { get; init; }

    [JsonPropertyName("type")]
    public required DocumentType Type { get; init; }

    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}
