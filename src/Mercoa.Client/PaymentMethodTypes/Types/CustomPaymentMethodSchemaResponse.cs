using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class CustomPaymentMethodSchemaResponse
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

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
    /// List of currencies that this payment method supports.
    /// </summary>
    [JsonPropertyName("supportedCurrencies")]
    public List<CurrencyCode> SupportedCurrencies { get; init; }

    [JsonPropertyName("fields")]
    public List<CustomPaymentMethodSchemaField> Fields { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }
}
