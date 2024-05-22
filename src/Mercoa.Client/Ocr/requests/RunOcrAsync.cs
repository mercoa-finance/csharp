using Mercoa.Client;

namespace Mercoa.Client;

public class RunOcrAsync
{
    /// <summary>
    /// Limit OCR vendor search to a specific network
    /// </summary>
    public VendorNetwork? VendorNetwork { get; init; }

    /// <summary>
    /// When using the Entity vendor network, specify the entity to use if. EntityId on an auth token will take precedence over this parameter.
    /// </summary>
    public string? EntityId { get; init; }

    /// <summary>
    /// MIME type of the image. Supported types are image/png, image/jpeg, and application/pdf.
    /// </summary>
    public string MimeType { get; init; }

    /// <summary>
    /// Base64 encoded image or PDF. PNG, JPG, and PDF are supported. 10MB max.
    /// </summary>
    public string Image { get; init; }
}
