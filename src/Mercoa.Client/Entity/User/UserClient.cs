using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Entity.User;

namespace Mercoa.Client.Entity.User;

public class UserClient
{
    private RawClient _client;

    public UserClient(RawClient client)
    {
        _client = client;
        NotificationPolicy = new NotificationPolicyClient(_client);
        Notifications = new NotificationsClient(_client);
    }

    public NotificationPolicyClient NotificationPolicy { get; }

    public NotificationsClient Notifications { get; }

    /// <summary>
    /// Get all entity users
    /// </summary>
    public async Task<List<EntityUserResponse>> GetAllAsync(string entityId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/{entityId}/users" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<List<EntityUserResponse>>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Get all entity users
    /// </summary>
    public async Task<FindEntityUserResponse> FindAsync(
        string entityId,
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
            _query["limit"] = request.Limit;
        }
        if (request.StartingAfter != null)
        {
            _query["startingAfter"] = request.StartingAfter;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Put,
                Path = $"/{entityId}/users",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<FindEntityUserResponse>(responseBody);
        }
        throw new Exception();
    }

    public async Task<EntityUserResponse> CreateAsync(string entityId, EntityUserRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/{entityId}/user",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EntityUserResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Get entity user
    /// </summary>
    public async Task<EntityUserResponse> GetAsync(string entityId, string userId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/{entityId}/user/{userId}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EntityUserResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Update entity user
    /// </summary>
    public async Task<EntityUserResponse> UpdateAsync(
        string entityId,
        string userId,
        EntityUserRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/{entityId}/user/{userId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EntityUserResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Delete entity user. This will also remove the user from all approval policies. If an approval policy will break as a result of this operation, this request will fail.
    /// </summary>
    public async void DeleteAsync(string entityId, string userId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/{entityId}/user/{userId}"
            }
        );
    }

    /// <summary>
    /// Generate a JWT token for an entity user with the given options. This token can be used to authenticate the entity and entity user in the Mercoa API and iFrame.
    /// </summary>
    public async Task<string> GetTokenAsync(
        string entityId,
        string userId,
        TokenGenerationOptions request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/{entityId}/user/{userId}/token",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<string>(responseBody);
        }
        throw new Exception();
    }
}
