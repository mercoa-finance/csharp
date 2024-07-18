using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record BirthDate
{
    [JsonPropertyName("day")]
    public string? Day { get; init; }

    [JsonPropertyName("month")]
    public string? Month { get; init; }

    [JsonPropertyName("year")]
    public string? Year { get; init; }
}
