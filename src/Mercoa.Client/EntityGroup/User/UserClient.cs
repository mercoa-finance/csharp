using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;
using Mercoa.Client.EntityGroup.User;

#nullable enable

namespace Mercoa.Client.EntityGroup.User;

public class UserClient
{
    private RawClient _client;

    public UserClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Search entity group users
    /// </summary>
    public async Task<FindEntityGroupUserResponse> FindAsync(
        string entityGroupId,
        EntityFindEntityRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.ForeignId != null)
        {
            _query["foreignId"] = request.ForeignId;
        }
        if (request.Role != null)
        {
            _query["role"] = request.Role;
        }
        if (request.Name != null)
        {
            _query["name"] = request.Name;
        }
        if (request.Email != null)
        {
            _query["email"] = request.Email;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.StartingAfter != null)
        {
            _query["startingAfter"] = request.StartingAfter;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entityGroup/{entityGroupId}/users",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<FindEntityGroupUserResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Create entity user that will be added to all entities in the group.
    /// </summary>
    public async Task<EntityGroupUserResponse> CreateAsync(
        string entityGroupId,
        EntityGroupUserRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entityGroup/{entityGroupId}/user",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<EntityGroupUserResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get entity user from a group
    /// </summary>
    public async Task<EntityGroupUserResponse> GetAsync(string entityGroupId, string foreignId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entityGroup/{entityGroupId}/user/{foreignId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<EntityGroupUserResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update entity user for all entities in the group.
    /// </summary>
    public async Task<EntityGroupUserResponse> UpdateAsync(
        string entityGroupId,
        string foreignId,
        EntityGroupUserRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entityGroup/{entityGroupId}/user/{foreignId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<EntityGroupUserResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Delete entity user from all entities in the group. This will also remove the user from all approval policies. If an approval policy will break as a result of this operation, this request will fail.
    /// </summary>
    public async Task DeleteAsync(string entityGroupId, string foreignId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/entityGroup/{entityGroupId}/user/{foreignId}"
            }
        );
    }
}
