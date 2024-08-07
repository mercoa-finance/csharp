using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record PaymentMethodCustomizationRequest
{
    [JsonPropertyName("type")]
    public required PaymentMethodType Type { get; init; }

    /// <summary>
    /// If type is custom, this is the ID of the schema to use for this payment method.
    /// </summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; init; }

    /// <summary>
    /// If true, this method will will not be available to the entity.
    /// </summary>
    [JsonPropertyName("disabled")]
    public required bool Disabled { get; init; }
}
