using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record EntityAddPayeesRequest
{
    /// <summary>
    /// List of payee entity IDs to associate with the entity
    /// </summary>
    [JsonPropertyName("payees")]
    public IEnumerable<string> Payees { get; init; } = new List<string>();

    /// <summary>
    /// List of customizations to apply to the payees. If the payee is not currently a counterparty of the entity, the counterparty will be created with the provided customizations.
    /// </summary>
    [JsonPropertyName("customizations")]
    public IEnumerable<CounterpartyCustomizationRequest>? Customizations { get; init; }
}
