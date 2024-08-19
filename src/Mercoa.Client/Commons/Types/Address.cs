using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record Address
{
    [JsonPropertyName("addressLine1")]
    public required string AddressLine1 { get; set; }

    [JsonPropertyName("addressLine2")]
    public string? AddressLine2 { get; set; }

    [JsonPropertyName("city")]
    public required string City { get; set; }

    /// <summary>
    /// State or province code. Must be in the format XX.
    /// </summary>
    [JsonPropertyName("stateOrProvince")]
    public required string StateOrProvince { get; set; }

    /// <summary>
    /// Postal code. Must be in the format XXXXX or XXXXX-XXXX.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public required string PostalCode { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }
}
