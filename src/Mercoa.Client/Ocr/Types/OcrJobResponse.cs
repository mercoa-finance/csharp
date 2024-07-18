using System.Text.Json.Serialization;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public record OcrJobResponse
{
    [JsonPropertyName("jobId")]
    public required string JobId { get; init; }

    [JsonPropertyName("status")]
    public required OcrJobStatus Status { get; init; }

    [JsonPropertyName("data")]
    public OcrResponse? Data { get; init; }
}
