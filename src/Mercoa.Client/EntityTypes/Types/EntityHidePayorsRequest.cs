using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class EntityHidePayorsRequest
{
    /// <summary>
    /// List of payor entity IDs to hide
    /// </summary>
    [JsonPropertyName("payors")]
    public List<string> Payors { get; init; }
}
