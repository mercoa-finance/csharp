using System.Text.Json;
using Mercoa.Client;

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
    public async Task<IEnumerable<EntityMetadataResponse>> GetAllAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/metadata" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<EntityMetadataResponse>>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Retrieve metadata associated with a specific key
    /// </summary>
    public async Task<IEnumerable<string>> GetAsync(string key)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/metadata/{key}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<string>>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update metadata associated with a specific key
    /// </summary>
    public async Task<IEnumerable<string>> UpdateAsync(string key, IEnumerable<string> request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/metadata/{key}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<string>>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Delete all metadata associated with a specific key
    /// </summary>
    public async void DeleteAsync(string key)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/metadata/{key}" }
        );
    }
}
