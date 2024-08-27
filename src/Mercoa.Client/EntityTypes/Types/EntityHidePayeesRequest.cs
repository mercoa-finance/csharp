using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityHidePayeesRequest
{
    /// <summary>
    /// List of payee entity IDs or foreign IDs to hide
    /// </summary>
    [JsonPropertyName("payees")]
    public IEnumerable<string> Payees { get; set; } = new List<string>();
}
