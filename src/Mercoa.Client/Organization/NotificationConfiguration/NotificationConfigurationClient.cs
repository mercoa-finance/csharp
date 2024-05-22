using System.Text.Json;
using Mercoa.Client;

namespace Mercoa.Client.Organization;

public class NotificationConfigurationClient
{
    private RawClient _client;

    public NotificationConfigurationClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieve all notification configurations
    /// </summary>
    public async Task<List<NotificationConfigurationResponse>> GetAllAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/notification-configurations"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<List<NotificationConfigurationResponse>>(
                responseBody
            );
        }
        throw new Exception();
    }

    /// <summary>
    /// Retrieve notification configuration for this notification type
    /// </summary>
    public async Task<NotificationConfigurationResponse> GetAsync(NotificationType notificationType)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/notification-configuration/{notificationType}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<NotificationConfigurationResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Update notification configuration for this notification type
    /// </summary>
    public async Task<NotificationConfigurationResponse> UpdateAsync(
        NotificationType notificationType,
        NotificationConfigurationRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/notification-configuration/{notificationType}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<NotificationConfigurationResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Reset notification configuration for this notification type
    /// </summary>
    public async void ResetAsync(NotificationType notificationType)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/notification-configuration/{notificationType}"
            }
        );
    }
}
