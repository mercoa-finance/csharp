using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class DocumentResponse
{
    /// <summary>
    /// ID of the document. If not provided, this is a dynamic document that is generated on the fly.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("mimeType")]
    public string MimeType { get; init; }

    [JsonPropertyName("uri")]
    public string Uri { get; init; }
}
