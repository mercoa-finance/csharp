using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class CustomPaymentMethodRequest
{
    /// <summary>
    /// ID for this payment method in your system
    /// </summary>
    [JsonPropertyName("foreignId")]
    public string ForeignId { get; init; }

    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    [JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; init; }

    /// <summary>
    /// Payment method schema used for this payment method. Defines the fields that this payment method contains.
    /// </summary>
    [JsonPropertyName("schemaId")]
    public string SchemaId { get; init; }

    /// <summary>
    /// Object of key/value pairs that matches the keys in the linked payment method schema.
    /// </summary>
    [JsonPropertyName("data")]
    public Dictionary<string, string> Data { get; init; }

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
}
