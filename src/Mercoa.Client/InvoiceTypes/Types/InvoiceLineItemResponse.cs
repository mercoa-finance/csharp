using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceLineItemResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Total amount of line item in major units.
    /// </summary>
    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    [JsonPropertyName("currency")]
    public required CurrencyCode Currency { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("quantity")]
    public double? Quantity { get; set; }

    /// <summary>
    /// Unit price of line item in major units.
    /// </summary>
    [JsonPropertyName("unitPrice")]
    public double? UnitPrice { get; set; }

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

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }
}
