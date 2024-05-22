using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class BankAccountUpdateRequest
{
    [JsonPropertyName("accountName")]
    public string? AccountName { get; init; }

    /// <summary>
    /// If provided, will update a bank account using Plaid Link
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
}
