using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Entity;

public class MetadataClient
{
    private RawClient _client;

    public MetadataClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieve all metadata options associated with this entity
    /// </summary>
    public async Task<IEnumerable<EntityMetadataResponse>> GetAllAsync(string entityId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/metadata"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<EntityMetadataResponse>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Retrieve metadata associated with a specific key
    /// </summary>
    public async Task<IEnumerable<string>> GetAsync(string entityId, string key)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/metadata/{key}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<string>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update metadata associated with a specific key
    /// </summary>
    public async Task<IEnumerable<string>> UpdateAsync(
        string entityId,
        string key,
        IEnumerable<string> request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/metadata/{key}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<string>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Delete all metadata associated with a specific key
    /// </summary>
    public async Task DeleteAsync(string entityId, string key)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/entity/{entityId}/metadata/{key}"
            }
        );
    }
}
