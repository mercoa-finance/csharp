using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class TokenGenerationOptions
{
    /// <summary>
    /// Expressed in seconds or a string describing a time span. The default is 1h.
    /// </summary>
    [JsonPropertyName("expiresIn")]
    public string? ExpiresIn { get; init; }

    [JsonPropertyName("invoice")]
    public TokenGenerationInvoiceOptions? Invoice { get; init; }

    [JsonPropertyName("pages")]
    public TokenGenerationPagesOptions? Pages { get; init; }

    [JsonPropertyName("style")]
    public TokenGenerationStyleOptions? Style { get; init; }

    [JsonPropertyName("vendors")]
    public TokenGenerationVendorOptions? Vendors { get; init; }

    [JsonPropertyName("entity")]
    public TokenGenerationEntityOptions? Entity { get; init; }
}
