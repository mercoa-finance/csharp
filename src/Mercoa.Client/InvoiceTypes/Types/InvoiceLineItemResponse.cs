using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class InvoiceLineItemResponse
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// Total amount of line item in major units.
    /// </summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; init; }

    [JsonPropertyName("currency")]
    public CurrencyCode Currency { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("quantity")]
    public int? Quantity { get; init; }

    /// <summary>
    /// Unit price of line item in major units.
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

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }
}
