using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityHidePayorsRequest
{
    /// <summary>
    /// List of payor entity IDs to hide
    /// </summary>
    [JsonPropertyName("payors")]
    public IEnumerable<string> Payors { get; init; } = new List<string>();
}
