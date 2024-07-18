using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Entity;

public class RepresentativeClient
{
    private RawClient _client;

    public RepresentativeClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get representatives for an entity
    /// </summary>
    public async Task<IEnumerable<RepresentativeResponse>> GetAllAsync(string entityId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/representatives"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<RepresentativeResponse>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<RepresentativeResponse> CreateAsync(
        string entityId,
        RepresentativeRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/representative",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<RepresentativeResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<RepresentativeResponse> GetAsync(string entityId, string representativeId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/representative/{representativeId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<RepresentativeResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task DeleteAsync(string entityId, string representativeId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/entity/{entityId}/representative/{representativeId}"
            }
        );
    }
}
