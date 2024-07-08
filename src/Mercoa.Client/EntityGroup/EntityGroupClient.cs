using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.EntityGroup;

#nullable enable

namespace Mercoa.Client.EntityGroup;

public class EntityGroupClient
{
    private RawClient _client;

    public EntityGroupClient(RawClient client)
    {
        _client = client;
        Invoice = new InvoiceClient(_client);
    }

    public InvoiceClient Invoice { get; }

    /// <summary>
    /// Get all entity groups. If using a JWT, will return all groups the entity is part of. If using an API key, will return all groups for the organization.
    /// </summary>
    public async Task<EntityGroupFindResponse> GetAllAsync(EntityGroupFindRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit;
        }
        if (request.StartingAfter != null)
        {
            _query["startingAfter"] = request.StartingAfter;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/entityGroups",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EntityGroupFindResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Create an entity group
    /// </summary>
    public async Task<EntityGroupResponse> CreateAsync(EntityGroupRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/entityGroup",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EntityGroupResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get an entity group
    /// </summary>
    public async Task<EntityGroupResponse> GetAsync(string entityGroupId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entityGroup/{entityGroupId}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EntityGroupResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update an entity group
    /// </summary>
    public async Task<EntityGroupResponse> UpdateAsync(
        string entityGroupId,
        EntityGroupRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entityGroup/{entityGroupId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EntityGroupResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Delete an entity group
    /// </summary>
    public async void DeleteAsync(string entityGroupId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/entityGroup/{entityGroupId}"
            }
        );
    }
}
