using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class EntityAddPayorsRequest
{
    /// <summary>
    /// List of payor entity IDs to associate with the entity
    /// </summary>
    [JsonPropertyName("payors")]
    public IEnumerable<string> Payors { get; init; }
}
