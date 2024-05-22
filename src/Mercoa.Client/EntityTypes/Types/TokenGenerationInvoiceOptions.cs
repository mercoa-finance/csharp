using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class TokenGenerationInvoiceOptions
{
    /// <summary>
    /// Defaults to OPTIONAL. If set to REQUIRED, the user will be required to provide at least one line item when creating an invoice. If set to DISABLED, the user will not be able to provide line items when creating an invoice.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public LineItemAvailabilities? LineItems { get; init; }

    /// <summary>
    /// DEPRECATED. Use lineItems instead.
    /// </summary>
    [JsonPropertyName("disableLineItems")]
    public bool? DisableLineItems { get; init; }

    [JsonPropertyName("status")]
    public List<InvoiceStatus> Status { get; init; }
}
