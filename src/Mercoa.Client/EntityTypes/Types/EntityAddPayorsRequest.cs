using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityAddPayorsRequest
{
    /// <summary>
    /// List of payor entity IDs to associate with the entity
    /// </summary>
    [JsonPropertyName("payors")]
    public IEnumerable<string> Payors { get; set; } = new List<string>();

    /// <summary>
    /// List of customizations to apply to the payors. If the payor is not currently a counterparty of the entity, the counterparty will be created with the provided customizations.
    /// </summary>
    [JsonPropertyName("customizations")]
    public IEnumerable<CounterpartyCustomizationRequest>? Customizations { get; set; }
}
