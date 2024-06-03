using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class BirthDate
{
    [JsonPropertyName("day")]
    public string? Day { get; init; }

    [JsonPropertyName("month")]
    public string? Month { get; init; }

    [JsonPropertyName("year")]
    public string? Year { get; init; }
}
