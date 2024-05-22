using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class EntityHidePayeesRequest
{
    /// <summary>
    /// List of payee entity IDs to hide
    /// </summary>
    [JsonPropertyName("payees")]
    public List<string> Payees { get; init; }
}
