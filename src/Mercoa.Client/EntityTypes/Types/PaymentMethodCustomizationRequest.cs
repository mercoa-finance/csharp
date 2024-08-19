using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record PaymentMethodCustomizationRequest
{
    [JsonPropertyName("type")]
    public required PaymentMethodType Type { get; set; }

    /// <summary>
    /// If type is custom, this is the ID of the schema to use for this payment method.
    /// </summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>
    /// If true, this method will will not be available to the entity.
    /// </summary>
    [JsonPropertyName("disabled")]
    public required bool Disabled { get; set; }
}
