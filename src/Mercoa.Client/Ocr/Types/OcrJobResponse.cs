using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public record OcrJobResponse
{
    [JsonPropertyName("jobId")]
    public required string JobId { get; set; }

    [JsonPropertyName("status")]
    public required OcrJobStatus Status { get; set; }

    [JsonPropertyName("data")]
    public OcrResponse? Data { get; set; }
}
