using System.Text.Json.Serialization;

namespace Mercoa.Client;

public class OcrAsyncResponse
{
    [JsonPropertyName("jobId")]
    public string JobId { get; init; }
}
