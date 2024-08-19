using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record BankAccountRequest
{
    /// <summary>
    /// The name of the account. For example "My Checking Account" or "Property XYZ Checking"
    /// </summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; set; }

    /// <summary>
    /// The name of the bank. This is now automatically set when the bank account is linked.
    /// </summary>
    [JsonPropertyName("bankName")]
    public string? BankName { get; set; }

    [JsonPropertyName("routingNumber")]
    public required string RoutingNumber { get; set; }

    [JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; set; }

    [JsonPropertyName("accountType")]
    public required BankType AccountType { get; set; }

    /// <summary>
    /// If provided, will link a bank account using Plaid Link
    /// </summary>
    [JsonPropertyName("plaid")]
    public PlaidLinkRequest? Plaid { get; set; }

    /// <summary>
    /// If this bank account supports check printing, use this to enable check printing and set the check options. Checks will be printed directly from the bank account.
    /// </summary>
    [JsonPropertyName("checkOptions")]
    public BankAccountCheckOptions? CheckOptions { get; set; }

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
