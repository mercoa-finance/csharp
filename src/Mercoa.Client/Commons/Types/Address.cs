using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class Address
{
    [JsonPropertyName("addressLine1")]
    public string AddressLine1 { get; init; }

    [JsonPropertyName("addressLine2")]
    public string? AddressLine2 { get; init; }

    [JsonPropertyName("city")]
    public string City { get; init; }

    /// <summary>
    /// State or province code. Must be in the format XX.
    /// </summary>
    [JsonPropertyName("stateOrProvince")]
    public string StateOrProvince { get; init; }

    /// <summary>
    /// Postal code. Must be in the format XXXXX or XXXXX-XXXX.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string PostalCode { get; init; }

    [JsonPropertyName("country")]
    public string? Country { get; init; }
}
