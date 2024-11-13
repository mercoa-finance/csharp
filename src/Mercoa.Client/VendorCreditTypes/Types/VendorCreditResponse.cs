using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record VendorCreditResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Total issued amount of the vendor credit in major units
    /// </summary>
    [JsonPropertyName("totalAmount")]
    public double? TotalAmount { get; set; }

    /// <summary>
    /// Remaining usable amount in the vendor credit in major units
    /// </summary>
    [JsonPropertyName("remainingAmount")]
    public double? RemainingAmount { get; set; }

    /// <summary>
    /// Currency code for the amount. Defaults to USD.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? Currency { get; set; }

    /// <summary>
    /// ID of the vendor the vendor credit may be used for
    /// </summary>
    [JsonPropertyName("vendorId")]
    public required string VendorId { get; set; }

    /// <summary>
    /// ID of the payer who may use the vendor credit
    /// </summary>
    [JsonPropertyName("payerId")]
    public required string PayerId { get; set; }

    /// <summary>
    /// ID of the entity that created this vendor credit
    /// </summary>
    [JsonPropertyName("creatorEntityId")]
    public string? CreatorEntityId { get; set; }

    /// <summary>
    /// An optional note to attach to the vendor credit
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// The IDs of the invoices that this vendor credit has been applied to
    /// </summary>
    [JsonPropertyName("invoiceIds")]
    public IEnumerable<string>? InvoiceIds { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }
}
