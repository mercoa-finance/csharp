using System.Text.Json;
using Mercoa.Client;

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
    public async Task<IEnumerable<RepresentativeResponse>> GetAllAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/representatives" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<RepresentativeResponse>>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<RepresentativeResponse> CreateAsync(RepresentativeRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/representative",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<RepresentativeResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<RepresentativeResponse> GetAsync(string representativeId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/representative/{representativeId}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<RepresentativeResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async void DeleteAsync(string representativeId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/representative/{representativeId}"
            }
        );
    }
}
