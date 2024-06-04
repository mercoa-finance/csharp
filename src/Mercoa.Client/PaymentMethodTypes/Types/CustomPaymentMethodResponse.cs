using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class CustomPaymentMethodResponse
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

    [JsonPropertyName("schema")]
    public CustomPaymentMethodSchemaResponse Schema { get; init; }

    /// <summary>
    /// Object of key/value pairs that matches the keys in the linked payment method schema.
    /// </summary>
    [JsonPropertyName("data")]
    public Dictionary<string, string> Data { get; init; }

    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// Indicates whether this payment method is the default source for the entity
    /// </summary>
    [JsonPropertyName("isDefaultSource")]
    public bool IsDefaultSource { get; init; }

    /// <summary>
    /// Indicates whether this payment method is the default destination for the entity
    /// </summary>
    [JsonPropertyName("isDefaultDestination")]
    public bool IsDefaultDestination { get; init; }

    [JsonPropertyName("supportedCurrencies")]
    public IEnumerable<CurrencyCode> SupportedCurrencies { get; init; }

    /// <summary>
    /// ID for this payment method in the external accounting system (e.g Rutter or Codat)
    /// </summary>
    [JsonPropertyName("externalAccountingSystemId")]
    public string? ExternalAccountingSystemId { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }
}
