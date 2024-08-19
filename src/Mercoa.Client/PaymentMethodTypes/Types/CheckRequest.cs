using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CheckRequest
{
    [JsonPropertyName("payToTheOrderOf")]
    public required string PayToTheOrderOf { get; set; }

    [JsonPropertyName("addressLine1")]
    public required string AddressLine1 { get; set; }

    [JsonPropertyName("addressLine2")]
    public string? AddressLine2 { get; set; }

    [JsonPropertyName("city")]
    public required string City { get; set; }

    [JsonPropertyName("stateOrProvince")]
    public required string StateOrProvince { get; set; }

    [JsonPropertyName("postalCode")]
    public required string PostalCode { get; set; }

    [JsonPropertyName("country")]
    public required string Country { get; set; }

    /// <summary>
    /// If true, this payment method will be set as the default source. Only one payment method can be set as the default source. If another payment method is already set as the default source, it will be unset.
    /// </summary>
    [JsonPropertyName("defaultSource")]
    public bool? DefaultSource { get; set; }

    /// <summary>
    /// If true, this payment method will be set as the default destination. Only one payment method can be set as the default destination. If another payment method is already set as the default destination, it will be unset.
    /// </summary>
    [JsonPropertyName("defaultDestination")]
    public bool? DefaultDestination { get; set; }

    /// <summary>
    /// ID for this payment method in the external accounting system (e.g Rutter or Codat)
    /// </summary>
    [JsonPropertyName("externalAccountingSystemId")]
    public string? ExternalAccountingSystemId { get; set; }

    /// <summary>
    /// If true, this payment method will be frozen. Frozen payment methods cannot be used for payments, but will still be returned in API responses.
    /// </summary>
    [JsonPropertyName("frozen")]
    public bool? Frozen { get; set; }

    /// <summary>
    /// Metadata associated with this payment method.
    /// </summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, string>? Metadata { get; set; }
}
