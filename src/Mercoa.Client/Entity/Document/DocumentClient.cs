using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;
using Mercoa.Client.Entity;

#nullable enable

namespace Mercoa.Client.Entity;

public class DocumentClient
{
    private RawClient _client;

    public DocumentClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get documents (1099/W9) associated with this entity
    /// </summary>
    public async Task<IEnumerable<DocumentResponse>> GetAllAsync(
        string entityId,
        GetDocumentsRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Type != null)
        {
            _query["type"] = JsonSerializer.Serialize(request.Type.Value);
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/documents",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<DocumentResponse>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Upload documents associated with this entity
    /// </summary>
    public async Task UploadAsync(string entityId, UploadDocumentRequest request)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/document",
                Body = request
            }
        );
    }

    /// <summary>
    /// Delete a document associated with this entity
    /// </summary>
    public async Task DeleteAsync(string entityId, string documentId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/entity/{entityId}/document/{documentId}"
            }
        );
    }
}
