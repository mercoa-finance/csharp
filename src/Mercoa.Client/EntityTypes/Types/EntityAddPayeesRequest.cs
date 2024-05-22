using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class EntityAddPayeesRequest
{
    /// <summary>
    /// List of payee entity IDs to associate with the entity
    /// </summary>
    [JsonPropertyName("payees")]
    public List<string> Payees { get; init; }
}
