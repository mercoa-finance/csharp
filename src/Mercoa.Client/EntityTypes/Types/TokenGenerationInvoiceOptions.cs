using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record TokenGenerationInvoiceOptions
{
    /// <summary>
    /// Defaults to OPTIONAL. If set to REQUIRED, the user will be required to provide at least one line item when creating an invoice. If set to DISABLED, the user will not be able to provide line items when creating an invoice.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public LineItemAvailabilities? LineItems { get; set; }

    /// <summary>
    /// DEPRECATED. Use lineItems instead.
    /// </summary>
    [JsonPropertyName("disableLineItems")]
    public bool? DisableLineItems { get; set; }

    [JsonPropertyName("status")]
    public IEnumerable<InvoiceStatus> Status { get; set; } = new List<InvoiceStatus>();
}
