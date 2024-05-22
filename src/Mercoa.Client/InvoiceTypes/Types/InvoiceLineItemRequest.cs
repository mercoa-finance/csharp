using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class InvoiceLineItemRequest
{
    /// <summary>
    /// If provided, will overwrite line item on the invoice with this ID. If not provided, will create a new line item.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Total amount of line item in major units. If the entered amount has more decimal places than the currency supports, trailing decimals will be truncated.
    /// </summary>
    [JsonPropertyName("amount")]
    public double Amount { get; init; }

    /// <summary>
    /// Currency code for the amount. Defaults to USD.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? Currency { get; init; }

    [JsonPropertyName("description")]
    public string Description { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("quantity")]
    public int? Quantity { get; init; }

    /// <summary>
    /// Unit price of the line item in major units. If the entered amount has more decimal places than the currency supports, trailing decimals will be truncated.
    /// </summary>
    [JsonPropertyName("unitPrice")]
    public double? UnitPrice { get; init; }

    [JsonPropertyName("serviceStartDate")]
    public DateTime? ServiceStartDate { get; init; }

    [JsonPropertyName("serviceEndDate")]
    public DateTime? ServiceEndDate { get; init; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, string>? Metadata { get; init; }

    /// <summary>
    /// ID of general ledger account associated with this line item.
    /// </summary>
    [JsonPropertyName("glAccountId")]
    public string? GlAccountId { get; init; }
}
