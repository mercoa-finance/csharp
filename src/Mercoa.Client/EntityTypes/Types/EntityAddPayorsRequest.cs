using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class EntityAddPayorsRequest
{
    /// <summary>
    /// List of payor entity IDs to associate with the entity
    /// </summary>
    [JsonPropertyName("payors")]
    public List<string> Payors { get; init; }
}
