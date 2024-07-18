using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

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
    public async Task<EntityCustomizationResponse> GetAsync(string entityId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/customization"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<EntityCustomizationResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update entity customization. This lets you turn off metadata and payment methods for an entity.
    /// </summary>
    public async Task<EntityCustomizationResponse> UpdateAsync(
        string entityId,
        EntityCustomizationRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/customization",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<EntityCustomizationResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
