using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record Address
{
    [JsonPropertyName("addressLine1")]
    public required string AddressLine1 { get; init; }

    [JsonPropertyName("addressLine2")]
    public string? AddressLine2 { get; init; }

    [JsonPropertyName("city")]
    public required string City { get; init; }

    /// <summary>
    /// State or province code. Must be in the format XX.
    /// </summary>
    [JsonPropertyName("stateOrProvince")]
    public required string StateOrProvince { get; init; }

    /// <summary>
    /// Postal code. Must be in the format XXXXX or XXXXX-XXXX.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public required string PostalCode { get; init; }

    [JsonPropertyName("country")]
    public string? Country { get; init; }
}
