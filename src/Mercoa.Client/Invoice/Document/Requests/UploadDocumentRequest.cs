using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client.Invoice;

public record UploadDocumentRequest
{
    /// <summary>
    /// Base64 encoded image or PDF of invoice document. PNG, JPG, WEBP, and PDF are supported. 10MB max.
    /// </summary>
    [JsonPropertyName("document")]
    public required string Document { get; init; }
}
