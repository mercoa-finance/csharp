using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record TokenGenerationOptions
{
    /// <summary>
    /// Expressed in seconds or a string describing a time span. The default is 1h.
    /// </summary>
    [JsonPropertyName("expiresIn")]
    public string? ExpiresIn { get; set; }

    [JsonPropertyName("invoice")]
    public TokenGenerationInvoiceOptions? Invoice { get; set; }

    [JsonPropertyName("pages")]
    public TokenGenerationPagesOptions? Pages { get; set; }

    [JsonPropertyName("style")]
    public TokenGenerationStyleOptions? Style { get; set; }

    [JsonPropertyName("vendors")]
    public TokenGenerationVendorOptions? Vendors { get; set; }

    [JsonPropertyName("entity")]
    public TokenGenerationEntityOptions? Entity { get; set; }
}
