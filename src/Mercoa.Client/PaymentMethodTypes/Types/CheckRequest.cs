using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class CheckRequest
{
    [JsonPropertyName("payToTheOrderOf")]
    public string PayToTheOrderOf { get; init; }

    [JsonPropertyName("addressLine1")]
    public string AddressLine1 { get; init; }

    [JsonPropertyName("addressLine2")]
    public string? AddressLine2 { get; init; }

    [JsonPropertyName("city")]
    public string City { get; init; }

    [JsonPropertyName("stateOrProvince")]
    public string StateOrProvince { get; init; }

    [JsonPropertyName("postalCode")]
    public string PostalCode { get; init; }

    [JsonPropertyName("country")]
    public string Country { get; init; }

    /// <summary>
    /// If true, this payment method will be set as the default source. Only one payment method can be set as the default source. If another payment method is already set as the default source, it will be unset.
    /// </summary>
    [JsonPropertyName("defaultSource")]
    public bool? DefaultSource { get; init; }

    /// <summary>
    /// If true, this payment method will be set as the default destination. Only one payment method can be set as the default destination. If another payment method is already set as the default destination, it will be unset.
    /// </summary>
    [JsonPropertyName("defaultDestination")]
    public bool? DefaultDestination { get; init; }

    /// <summary>
    /// ID for this payment method in the external accounting system (e.g Rutter or Codat)
    /// </summary>
    [JsonPropertyName("externalAccountingSystemId")]
    public string? ExternalAccountingSystemId { get; init; }
}
