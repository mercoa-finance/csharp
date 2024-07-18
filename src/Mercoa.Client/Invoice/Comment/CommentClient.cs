using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

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
    public async Task<IEnumerable<CommentResponse>> GetAllAsync(string invoiceId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/invoice/{invoiceId}/comments"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<CommentResponse>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Add a comment to this invoice
    /// </summary>
    public async Task<CommentResponse> CreateAsync(string invoiceId, CommentRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/invoice/{invoiceId}/comment",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<CommentResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<CommentResponse> GetAsync(string invoiceId, string commentId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/invoice/{invoiceId}/comment/{commentId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<CommentResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Edit a comment on this invoice
    /// </summary>
    public async Task<CommentResponse> UpdateAsync(
        string invoiceId,
        string commentId,
        CommentRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/invoice/{invoiceId}/comment/{commentId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<CommentResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Delete a comment on this invoice
    /// </summary>
    public async Task DeleteAsync(string invoiceId, string commentId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/invoice/{invoiceId}/comment/{commentId}"
            }
        );
    }
}
