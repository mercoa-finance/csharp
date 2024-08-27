using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityHidePayorsRequest
{
    /// <summary>
    /// List of payor entity IDs or foreign IDs to hide
    /// </summary>
    [JsonPropertyName("payors")]
    public IEnumerable<string> Payors { get; set; } = new List<string>();
}
