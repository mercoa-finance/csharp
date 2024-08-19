using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record BankAccountResponse
{
    [JsonPropertyName("accountName")]
    public required string AccountName { get; set; }

    [JsonPropertyName("bankName")]
    public required string BankName { get; set; }

    [JsonPropertyName("routingNumber")]
    public required string RoutingNumber { get; set; }

    [JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }

    [JsonPropertyName("accountType")]
    public required BankType AccountType { get; set; }

    [JsonPropertyName("status")]
    public required BankStatus Status { get; set; }

    /// <summary>
    /// If check printing is enabled for the account, will return the check options for this bank account
    /// </summary>
    [JsonPropertyName("checkOptions")]
    public BankAccountCheckOptions? CheckOptions { get; set; }

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
