using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CustomPaymentMethodUpdateRequest
{
    /// <summary>
    /// ID for this payment method in your system
    /// </summary>
    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; set; }

    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    [JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; set; }

    /// <summary>
    /// The available balance for this payment method.
    /// </summary>
    [JsonPropertyName("availableBalance")]
    public double? AvailableBalance { get; set; }

    /// <summary>
    /// Payment method schema used for this payment method. Defines the fields that this payment method contains.
    /// </summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>
    /// Object of key/value pairs that matches the keys in the linked payment method schema.
    /// </summary>
    [JsonPropertyName("data")]
    public Dictionary<string, string>? Data { get; set; }

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
