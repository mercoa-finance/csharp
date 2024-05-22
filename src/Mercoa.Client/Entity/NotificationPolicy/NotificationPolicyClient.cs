using System.Text.Json;
using Mercoa.Client;

namespace Mercoa.Client.Entity;

public class NotificationPolicyClient
{
    private RawClient _client;

    public NotificationPolicyClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieve all notification policies associated with this entity
    /// </summary>
    public async Task<List<NotificationPolicyResponse>> GetAllAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/notification-policies" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<List<NotificationPolicyResponse>>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Retrieve notification policy associated with this entity
    /// </summary>
    public async Task<NotificationPolicyResponse> GetAsync(NotificationType notificationType)
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
            return JsonSerializer.Deserialize<NotificationPolicyResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Update notification policy associated with this entity
    /// </summary>
    public async Task<NotificationPolicyResponse> UpdateAsync(
        NotificationType notificationType,
        NotificationPolicyRequest request
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
            return JsonSerializer.Deserialize<NotificationPolicyResponse>(responseBody);
        }
        throw new Exception();
    }
}
