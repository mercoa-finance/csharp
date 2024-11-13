using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record VendorCreditRequest
{
    /// <summary>
    /// Total amount of the vendor credit in major units
    /// </summary>
    [JsonPropertyName("totalAmount")]
    public required double TotalAmount { get; set; }

    /// <summary>
    /// Currency code for the amount. Defaults to USD.
    /// </summary>
    [JsonPropertyName("currency")]
    public required CurrencyCode Currency { get; set; }

    /// <summary>
    /// An optional note to attach to the vendor credit
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }
}
