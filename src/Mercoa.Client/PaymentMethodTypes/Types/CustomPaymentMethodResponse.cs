using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CustomPaymentMethodResponse
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
    public required string SchemaId { get; set; }

    [JsonPropertyName("schema")]
    public required CustomPaymentMethodSchemaResponse Schema { get; set; }

    /// <summary>
    /// Object of key/value pairs that matches the keys in the linked payment method schema.
    /// </summary>
    [JsonPropertyName("data")]
    public Dictionary<string, string> Data { get; set; } = new Dictionary<string, string>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Indicates whether this payment method is the default source for the entity
    /// </summary>
    [JsonPropertyName("isDefaultSource")]
    public required bool IsDefaultSource { get; set; }

    /// <summary>
    /// Indicates whether this payment method is the default destination for the entity
    /// </summary>
    [JsonPropertyName("isDefaultDestination")]
    public required bool IsDefaultDestination { get; set; }

    [JsonPropertyName("supportedCurrencies")]
    public IEnumerable<CurrencyCode> SupportedCurrencies { get; set; } = new List<CurrencyCode>();

    /// <summary>
    /// ID for this payment method in the external accounting system (e.g Rutter or Codat)
    /// </summary>
    [JsonPropertyName("externalAccountingSystemId")]
    public string? ExternalAccountingSystemId { get; set; }

    /// <summary>
    /// Frozen payment methods cannot be used for payments, but will still be returned in API responses.
    /// </summary>
    [JsonPropertyName("frozen")]
    public required bool Frozen { get; set; }

    /// <summary>
    /// Metadata associated with this payment method.
    /// </summary>
    [JsonPropertyName("metadata")]
    public Dictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }
}
