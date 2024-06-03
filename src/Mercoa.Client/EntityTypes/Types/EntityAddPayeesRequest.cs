using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class EntityAddPayeesRequest
{
    /// <summary>
    /// List of payee entity IDs to associate with the entity
    /// </summary>
    [JsonPropertyName("payees")]
    public IEnumerable<string> Payees { get; init; }
}
