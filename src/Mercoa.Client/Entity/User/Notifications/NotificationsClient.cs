using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Entity.User;

namespace Mercoa.Client.Entity.User;

public class NotificationsClient
{
    private RawClient _client;

    public NotificationsClient(RawClient client)
    {
        _client = client;
    }

    public async Task<FindNotificationResponse> FindAsync(EntityGetNotificationsRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.StartDate != null)
        {
            _query["startDate"] = request.StartDate;
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate;
        }
        if (request.OrderDirection != null)
        {
            _query["orderDirection"] = request.OrderDirection;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit;
        }
        if (request.StartingAfter != null)
        {
            _query["startingAfter"] = request.StartingAfter;
        }
        if (request.NotificationType != null)
        {
            _query["notificationType"] = request.NotificationType;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/notifications",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<FindNotificationResponse>(responseBody);
        }
        throw new Exception();
    }

    public async Task<NotificationResponse> GetAsync(string notificationId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/notification/{notificationId}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<NotificationResponse>(responseBody);
        }
        throw new Exception();
    }
}
