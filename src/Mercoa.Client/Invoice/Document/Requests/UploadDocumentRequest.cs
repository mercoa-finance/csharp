using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client.Invoice;

public class UploadDocumentRequest
{
    /// <summary>
    /// Base64 encoded image or PDF of invoice document. PNG, JPG, and PDF are supported. 10MB max.
    /// </summary>
    [JsonPropertyName("document")]
    public string? Document { get; init; }
}
