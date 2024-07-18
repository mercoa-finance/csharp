using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;
using Mercoa.Client.Entity.User;

#nullable enable

namespace Mercoa.Client.Entity.User;

public class NotificationsClient
{
    private RawClient _client;

    public NotificationsClient(RawClient client)
    {
        _client = client;
    }

    public async Task<FindNotificationResponse> FindAsync(
        string entityId,
        string userId,
        EntityGetNotificationsRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.StartDate != null)
        {
            _query["startDate"] = request.StartDate.Value.ToString("o0");
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate.Value.ToString("o0");
        }
        if (request.OrderDirection != null)
        {
            _query["orderDirection"] = JsonSerializer.Serialize(request.OrderDirection.Value);
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.StartingAfter != null)
        {
            _query["startingAfter"] = request.StartingAfter;
        }
        if (request.NotificationType != null)
        {
            _query["notificationType"] = JsonSerializer.Serialize(request.NotificationType.Value);
        }
        if (request.Status != null)
        {
            _query["status"] = JsonSerializer.Serialize(request.Status.Value);
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/user/{userId}/notifications",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<FindNotificationResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<NotificationResponse> GetAsync(
        string entityId,
        string userId,
        string notificationId
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/user/{userId}/notification/{notificationId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<NotificationResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update the status of a notification.
    /// </summary>
    public async Task<NotificationResponse> UpdateAsync(
        string entityId,
        string userId,
        string notificationId,
        NotificationUpdateRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Put,
                Path = $"/entity/{entityId}/user/{userId}/notification/{notificationId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<NotificationResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
