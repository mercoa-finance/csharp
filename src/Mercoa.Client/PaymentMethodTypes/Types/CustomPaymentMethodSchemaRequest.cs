using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class CustomPaymentMethodSchemaRequest
{
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// This payment method can be used as a payment source for an invoice
    /// </summary>
    [JsonPropertyName("isSource")]
    public bool IsSource { get; init; }

    /// <summary>
    /// This payment method can be used as a payment destination for an invoice
    /// </summary>
    [JsonPropertyName("isDestination")]
    public bool IsDestination { get; init; }

    /// <summary>
    /// List of currencies that this payment method supports. If not provided, the payment method will support only USD.
    /// </summary>
    [JsonPropertyName("supportedCurrencies")]
    public List<CurrencyCode>? SupportedCurrencies { get; init; }

    [JsonPropertyName("fields")]
    public List<CustomPaymentMethodSchemaField> Fields { get; init; }
}
