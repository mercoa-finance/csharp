using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class CustomPaymentMethodSchemaField
{
    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; init; }

    [JsonPropertyName("type")]
    public CustomPaymentMethodSchemaFieldType Type { get; init; }

    /// <summary>
    /// Indicates whether this field is optional
    /// </summary>
    [JsonPropertyName("optional")]
    public bool Optional { get; init; }

    /// <summary>
    /// Indicates whether this field should be used as the name of the payment method. Only one field can be used as the name. Will set the accountName field of the payment method to the value of this field.
    /// </summary>
    [JsonPropertyName("useAsAccountName")]
    public bool? UseAsAccountName { get; init; }

    /// <summary>
    /// Indicates whether this field should be used as the account number of the payment method. Only one field can be used as the account number. Will set the accountNumber field of the payment method to the value of this field.
    /// </summary>
    [JsonPropertyName("useAsAccountNumber")]
    public bool? UseAsAccountNumber { get; init; }

    /// <summary>
    /// When type is 'select', provide options that can be selected
    /// </summary>
    [JsonPropertyName("options")]
    public IEnumerable<string>? Options { get; init; }
}
