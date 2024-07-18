using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Entity.User;

public class NotificationPolicyClient
{
    private RawClient _client;

    public NotificationPolicyClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieve all notification policies associated with this entity user
    /// </summary>
    public async Task<IEnumerable<UserNotificationPolicyResponse>> GetAllAsync(
        string entityId,
        string userId
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/user/{userId}/notification-policies"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<UserNotificationPolicyResponse>>(
                responseBody
            )!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Retrieve notification policy associated with this entity user
    /// </summary>
    public async Task<UserNotificationPolicyResponse> GetAsync(
        string entityId,
        string userId,
        NotificationType notificationType
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/user/{userId}/notification-policy/{notificationType}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<UserNotificationPolicyResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update notification policy associated with this entity user
    /// </summary>
    public async Task<UserNotificationPolicyResponse> UpdateAsync(
        string entityId,
        string userId,
        NotificationType notificationType,
        UserNotificationPolicyRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/user/{userId}/notification-policy/{notificationType}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<UserNotificationPolicyResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
