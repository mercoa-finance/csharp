using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceLineItemCreationRequest
{
    /// <summary>
    /// Total amount of line item in major units. If the entered amount has more decimal places than the currency supports, trailing decimals will be truncated.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// Currency code for the amount. Defaults to USD.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? Currency { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    /// Unit price of the line item in major units. If the entered amount has more decimal places than the currency supports, trailing decimals will be truncated.
    /// </summary>
    [JsonPropertyName("unitPrice")]
    public double? UnitPrice { get; set; }

    /// <summary>
    /// Category of the line item. Defaults to EXPENSE.
    /// </summary>
    [JsonPropertyName("category")]
    public InvoiceLineItemCategory? Category { get; set; }

    [JsonPropertyName("serviceStartDate")]
    public DateTime? ServiceStartDate { get; set; }

    [JsonPropertyName("serviceEndDate")]
    public DateTime? ServiceEndDate { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// ID of general ledger account associated with this line item.
    /// </summary>
    [JsonPropertyName("glAccountId")]
    public string? GlAccountId { get; set; }
}
