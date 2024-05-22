using System.Text.Json;
using Mercoa.Client;

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
    public async Task<List<UserNotificationPolicyResponse>> GetAllAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/notification-policies" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<List<UserNotificationPolicyResponse>>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Retrieve notification policy associated with this entity user
    /// </summary>
    public async Task<UserNotificationPolicyResponse> GetAsync(NotificationType notificationType)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/notification-policy/{notificationType}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<UserNotificationPolicyResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Update notification policy associated with this entity user
    /// </summary>
    public async Task<UserNotificationPolicyResponse> UpdateAsync(
        NotificationType notificationType,
        UserNotificationPolicyRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/notification-policy/{notificationType}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<UserNotificationPolicyResponse>(responseBody);
        }
        throw new Exception();
    }
}
