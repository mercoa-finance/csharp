using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record PaymentMethodBaseRequest
{
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
