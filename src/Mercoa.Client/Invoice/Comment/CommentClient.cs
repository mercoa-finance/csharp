using System.Text.Json;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.Invoice;

public class CommentClient
{
    private RawClient _client;

    public CommentClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get all comments associated with this invoice
    /// </summary>
    public async Task<IEnumerable<CommentResponse>> GetAllAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/comments" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<CommentResponse>>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Add a comment to this invoice
    /// </summary>
    public async Task<CommentResponse> CreateAsync(CommentRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/comment",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CommentResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<CommentResponse> GetAsync(string commentId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/comment/{commentId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CommentResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Edit a comment on this invoice
    /// </summary>
    public async Task<CommentResponse> UpdateAsync(string commentId, CommentRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/comment/{commentId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CommentResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Delete a comment on this invoice
    /// </summary>
    public async void DeleteAsync(string commentId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/comment/{commentId}" }
        );
    }
}
