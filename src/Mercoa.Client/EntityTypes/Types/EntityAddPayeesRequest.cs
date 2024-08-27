using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityAddPayeesRequest
{
    /// <summary>
    /// List of payee entity IDs or foreign IDs to associate with the entity
    /// </summary>
    [JsonPropertyName("payees")]
    public IEnumerable<string> Payees { get; set; } = new List<string>();

    /// <summary>
    /// List of customizations to apply to the payees. If the payee is not currently a counterparty of the entity, the counterparty will be created with the provided customizations.
    /// </summary>
    [JsonPropertyName("customizations")]
    public IEnumerable<CounterpartyCustomizationRequest>? Customizations { get; set; }
}
