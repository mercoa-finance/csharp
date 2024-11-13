using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.InvoiceTemplate;

public record UploadDocumentRequest
{
    /// <summary>
    /// Base64 encoded image or PDF of invoice document. PNG, JPG, WEBP, and PDF are supported. 10MB max.
    /// </summary>
    [JsonPropertyName("document")]
    public required string Document { get; set; }

    /// <summary>
    /// Specify Document Type, defaults to INVOICE
    /// </summary>
    [JsonPropertyName("type")]
    public DocumentType? Type { get; set; }
}
