using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class MetadataSchema
{
    [JsonPropertyName("key")]
    public string Key { get; init; }

    [JsonPropertyName("displayName")]
    public string DisplayName { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Whether or not this field should be shown on line items. If true, this field will be shown on each line item. If false, the field will be shown on the invoice level. Defaults to false.
    /// </summary>
    [JsonPropertyName("lineItem")]
    public bool? LineItem { get; init; }

    [JsonPropertyName("type")]
    public MetadataType Type { get; init; }

    /// <summary>
    /// Whether or not multiple values are allowed for this field. Defaults to false. If true, the value will be a list of the specified type.
    /// </summary>
    [JsonPropertyName("allowMultiple")]
    public bool? AllowMultiple { get; init; }

    /// <summary>
    /// Validation rules are currently only supported for STRING types.
    /// </summary>
    [JsonPropertyName("validationRules")]
    public MetadataValidationRule? ValidationRules { get; init; }

    /// <summary>
    /// A list of conditional rules that determine whether or not this field should be shown. The field will only be shown if all of the conditions are met. If no conditions are specified, the field will always be shown.
    /// </summary>
    [JsonPropertyName("showConditions")]
    public MetadataShowConditions? ShowConditions { get; init; }
}
