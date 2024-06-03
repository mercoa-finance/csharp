using System.Text.Json;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class OcrClient
{
    private RawClient _client;

    public OcrClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Run OCR on an Base64 encoded image or PDF. This endpoint will block until the OCR is complete.
    /// </summary>
    public async Task<OcrResponse> OcrAsync(OcrRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/ocr",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<OcrResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Run OCR on an Base64 encoded image or PDF. This endpoint will return immediately and the OCR will be processed asynchronously.
    /// </summary>
    public async Task<OcrAsyncResponse> RunAsyncOcrAsync(OcrRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/ocr-async",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<OcrAsyncResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get the status and results of an asynchronous OCR job.
    /// </summary>
    public async Task<OcrJobResponse> GetAsyncOcrAsync(string jobId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/ocr-async/{jobId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<OcrJobResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
