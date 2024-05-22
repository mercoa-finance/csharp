using System.Text.Json.Serialization;
using Mercoa.Client;

namespace Mercoa.Client;

public class OcrJobResponse
{
    [JsonPropertyName("jobId")]
    public string JobId { get; init; }

    [JsonPropertyName("status")]
    public OcrJobStatus Status { get; init; }

    [JsonPropertyName("data")]
    public OcrResponse? Data { get; init; }
}
