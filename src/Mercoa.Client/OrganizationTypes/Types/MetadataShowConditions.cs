using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class MetadataShowConditions
{
    /// <summary>
    /// Show this field only if the entity has values set for the metadata key.
    /// </summary>
    [JsonPropertyName("hasOptions")]
    public bool? HasOptions { get; init; }

    /// <summary>
    /// Show this field only if a document has been attached.
    /// </summary>
    [JsonPropertyName("hasDocument")]
    public bool? HasDocument { get; init; }

    /// <summary>
    /// Show this field only if the invoice has no line items. Useful for showing a field that applies to the entire invoice but overridden by line items if present.
    /// </summary>
    [JsonPropertyName("hasNoLineItems")]
    public bool? HasNoLineItems { get; init; }

    /// <summary>
    /// Show this field only if the payment source type is in this list.
    /// </summary>
    [JsonPropertyName("paymentSourceTypes")]
    public List<PaymentMethodType>? PaymentSourceTypes { get; init; }

    /// <summary>
    /// Show this field only if the payment source schema ID is in this list of payment source schema IDs. This is only applicable if paymentSourceTypes contains CUSTOM.
    /// </summary>
    [JsonPropertyName("paymentSourceCustomSchemaIds")]
    public List<string>? PaymentSourceCustomSchemaIds { get; init; }

    /// <summary>
    /// Show this field only if the payment destination type is in this list.
    /// </summary>
    [JsonPropertyName("paymentDestinationTypes")]
    public List<PaymentMethodType>? PaymentDestinationTypes { get; init; }

    /// <summary>
    /// Show this field only if the payment destination schema ID is in this list of payment destination schema IDs. This is only applicable if paymentDestinationTypes contains CUSTOM.
    /// </summary>
    [JsonPropertyName("paymentDestinationCustomSchemaIds")]
    public List<string>? PaymentDestinationCustomSchemaIds { get; init; }
}
