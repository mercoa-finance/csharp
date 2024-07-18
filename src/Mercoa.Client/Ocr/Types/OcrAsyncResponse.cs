using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record OcrAsyncResponse
{
    [JsonPropertyName("jobId")]
    public required string JobId { get; init; }
}
