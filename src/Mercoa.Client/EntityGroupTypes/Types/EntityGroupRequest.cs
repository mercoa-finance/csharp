using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record EntityGroupRequest
{
    [JsonPropertyName("entityIds")]
    public IEnumerable<string> EntityIds { get; set; } = new List<string>();

    [JsonPropertyName("foreignId")]
    public string? ForeignId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("emailToName")]
    public string? EmailToName { get; set; }
}
