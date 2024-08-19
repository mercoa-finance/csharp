using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CounterpartyCustomizationAccount
{
    /// <summary>
    /// The ID the counterparty has assigned to this account.
    /// </summary>
    [JsonPropertyName("accountId")]
    public required string AccountId { get; set; }

    /// <summary>
    /// The postal code the counterparty has assigned to this account.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// The name on the account the counterparty has assigned to this account.
    /// </summary>
    [JsonPropertyName("nameOnAccount")]
    public string? NameOnAccount { get; set; }
}
