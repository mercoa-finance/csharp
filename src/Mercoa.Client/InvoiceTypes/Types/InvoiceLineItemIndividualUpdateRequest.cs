using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record InvoiceLineItemIndividualUpdateRequest
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
