using System.Text.Json;
using Mercoa.Client;

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
    public async Task<List<EntityMetadataResponse>> GetAllAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/metadata" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<List<EntityMetadataResponse>>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Retrieve metadata associated with a specific key
    /// </summary>
    public async Task<List<string>> GetAsync(string key)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/metadata/{key}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<List<string>>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Update metadata associated with a specific key
    /// </summary>
    public async Task<List<string>> UpdateAsync(string key, List<string> request)
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
            return JsonSerializer.Deserialize<List<string>>(responseBody);
        }
        throw new Exception();
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
