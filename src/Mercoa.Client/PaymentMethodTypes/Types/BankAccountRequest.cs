using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record BankAccountRequest
{
    /// <summary>
    /// The name of the account. For example "My Checking Account" or "Property XYZ Checking"
    /// </summary>
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// The name of the bank. This is now automatically set when the bank account is linked.
    /// </summary>
    [JsonPropertyName("bankName")]
    public string? BankName { get; init; }

    [JsonPropertyName("routingNumber")]
    public required string RoutingNumber { get; init; }

    [JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; init; }

    [JsonPropertyName("accountType")]
    public required BankType AccountType { get; init; }

    /// <summary>
    /// If provided, will link a bank account using Plaid Link
    /// </summary>
    [JsonPropertyName("plaid")]
    public PlaidLinkRequest? Plaid { get; init; }

    /// <summary>
    /// If this bank account supports check printing, use this to enable check printing and set the check options. Checks will be printed directly from the bank account.
    /// </summary>
    [JsonPropertyName("checkOptions")]
    public BankAccountCheckOptions? CheckOptions { get; init; }

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
