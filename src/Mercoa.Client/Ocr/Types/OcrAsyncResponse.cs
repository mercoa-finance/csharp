using System.Text.Json.Serialization;

#nullable enable

namespace Mercoa.Client;

public class OcrAsyncResponse
{
    [JsonPropertyName("jobId")]
    public string JobId { get; init; }
}
