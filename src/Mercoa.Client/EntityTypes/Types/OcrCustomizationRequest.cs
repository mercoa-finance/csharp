using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record OcrCustomizationRequest
{
    /// <summary>
    /// Extract line items from the invoice. Defaults to true.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public bool? LineItems { get; set; }

    /// <summary>
    /// Pull custom metadata at the invoice level. Defaults to true.
    /// </summary>
    [JsonPropertyName("invoiceMetadata")]
    public bool? InvoiceMetadata { get; set; }

    /// <summary>
    /// Pull custom metadata at the line item level. Defaults to true.
    /// </summary>
    [JsonPropertyName("lineItemMetadata")]
    public bool? LineItemMetadata { get; set; }

    /// <summary>
    /// Pull GL Account ID at the line item level. Defaults to true.
    /// </summary>
    [JsonPropertyName("lineItemGlAccountId")]
    public bool? LineItemGlAccountId { get; set; }

    /// <summary>
    /// Use AI to predict metadata from historical data. Defaults to true.
    /// </summary>
    [JsonPropertyName("predictMetadata")]
    public bool? PredictMetadata { get; set; }

    /// <summary>
    /// Pull tax and shipping information as line items. Defaults to true. If false, tax and shipping will extracted as invoice level fields.
    /// </summary>
    [JsonPropertyName("taxAndShippingAsLineItems")]
    public bool? TaxAndShippingAsLineItems { get; set; }
}
