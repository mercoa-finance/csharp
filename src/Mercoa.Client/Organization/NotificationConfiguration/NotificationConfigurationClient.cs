using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

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
    public async Task<IEnumerable<object>> GetAllAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/organization/notification-configurations"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<object>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Retrieve notification configuration for this notification type
    /// </summary>
    public async Task<object> GetAsync(NotificationType notificationType)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/organization/notification-configuration/{notificationType}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<object>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update notification configuration for this notification type
    /// </summary>
    public async Task<object> UpdateAsync(NotificationType notificationType, object request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/organization/notification-configuration/{notificationType}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<object>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Reset notification configuration for this notification type
    /// </summary>
    public async Task ResetAsync(NotificationType notificationType)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/organization/notification-configuration/{notificationType}"
            }
        );
    }
}
