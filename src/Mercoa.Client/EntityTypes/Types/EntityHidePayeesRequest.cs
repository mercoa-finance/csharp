using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class EntityHidePayeesRequest
{
    /// <summary>
    /// List of payee entity IDs to hide
    /// </summary>
    [JsonPropertyName("payees")]
    public IEnumerable<string> Payees { get; init; }
}
