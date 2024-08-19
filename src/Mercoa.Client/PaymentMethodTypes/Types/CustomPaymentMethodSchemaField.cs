using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record CustomPaymentMethodSchemaField
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("type")]
    public required CustomPaymentMethodSchemaFieldType Type { get; set; }

    /// <summary>
    /// Indicates whether this field is optional
    /// </summary>
    [JsonPropertyName("optional")]
    public required bool Optional { get; set; }

    /// <summary>
    /// Indicates whether this field should be used as the name of the payment method. Only one field can be used as the name. Will set the accountName field of the payment method to the value of this field.
    /// </summary>
    [JsonPropertyName("useAsAccountName")]
    public bool? UseAsAccountName { get; set; }

    /// <summary>
    /// Indicates whether this field should be used as the account number of the payment method. Only one field can be used as the account number. Will set the accountNumber field of the payment method to the value of this field.
    /// </summary>
    [JsonPropertyName("useAsAccountNumber")]
    public bool? UseAsAccountNumber { get; set; }

    /// <summary>
    /// When type is 'select', provide options that can be selected
    /// </summary>
    [JsonPropertyName("options")]
    public IEnumerable<string>? Options { get; set; }
}
