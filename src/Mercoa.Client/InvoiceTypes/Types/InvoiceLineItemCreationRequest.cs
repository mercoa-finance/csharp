using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record InvoiceLineItemCreationRequest
{
    /// <summary>
    /// Total amount of line item in major units. If the entered amount has more decimal places than the currency supports, trailing decimals will be truncated.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// Currency code for the amount. Defaults to USD.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? Currency { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("quantity")]
    public double? Quantity { get; init; }

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
