using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class EntityAddPayorsRequest
{
    /// <summary>
    /// List of payor entity IDs to associate with the entity
    /// </summary>
    [JsonPropertyName("payors")]
    public IEnumerable<string> Payors { get; init; }

    /// <summary>
    /// List of customizations to apply to the payors. If the payor is not currently a counterparty of the entity, the counterparty will be created with the provided customizations.
    /// </summary>
    [JsonPropertyName("customizations")]
    public IEnumerable<CounterpartyCustomizationRequest>? Customizations { get; init; }
}
