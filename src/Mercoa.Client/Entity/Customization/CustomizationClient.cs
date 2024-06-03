using System.Text.Json;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.Entity;

public class CustomizationClient
{
    private RawClient _client;

    public CustomizationClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get entity customization.
    /// </summary>
    public async Task<EntityCustomizationResponse> GetAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/customization" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EntityCustomizationResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update entity customization. This lets you turn off metadata and payment methods for an entity.
    /// </summary>
    public async Task<EntityCustomizationResponse> UpdateAsync(EntityCustomizationRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/customization",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EntityCustomizationResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
