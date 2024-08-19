using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record OcrRequest
{
    /// <summary>
    /// MIME type of the image. Supported types are image/png, image/jpeg, and application/pdf.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public required string MimeType { get; set; }

    /// <summary>
    /// Base64 encoded image or PDF. PNG, JPG, WEBP, and PDF are supported. 10MB max.
    /// </summary>
    [JsonPropertyName("image")]
    public required string Image { get; set; }

    /// <summary>
    /// Limit OCR vendor search to a specific network
    /// </summary>
    [JsonPropertyName("vendorNetwork")]
    public VendorNetwork? VendorNetwork { get; set; }

    /// <summary>
    /// When using the Entity vendor network, specify the entity to use if. EntityId on an auth token will take precedence over this parameter.
    /// </summary>
    [JsonPropertyName("entityId")]
    public string? EntityId { get; set; }
}
