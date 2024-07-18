using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.Entity;

public record UploadDocumentRequest
{
    /// <summary>
    /// Base64 encoded image or PDF of document. PNG, JPG, WEBP, and PDF are supported. 10MB max.
    /// </summary>
    [JsonPropertyName("document")]
    public required string Document { get; init; }

    [JsonPropertyName("type")]
    public required DocumentType Type { get; init; }
}
