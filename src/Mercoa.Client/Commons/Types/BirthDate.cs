using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record BirthDate
{
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    [JsonPropertyName("month")]
    public string? Month { get; set; }

    [JsonPropertyName("year")]
    public string? Year { get; set; }
}
