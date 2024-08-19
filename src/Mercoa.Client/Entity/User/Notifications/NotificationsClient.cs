using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Entity.User;

public partial class NotificationsClient
{
    private RawClient _client;

    internal NotificationsClient(RawClient client)
    {
        _client = client;
    }

    public async Task<FindNotificationResponse> FindAsync(
        string entityId,
        string userId,
        EntityGetNotificationsRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["notificationType"] = request
            .NotificationType.Select(_value => _value.ToString())
            .ToList();
        if (request.StartDate != null)
        {
            _query["startDate"] = request.StartDate.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate.Value.ToString(Constants.DateTimeFormat);
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
        if (request.Status != null)
        {
            _query["status"] = JsonSerializer.Serialize(request.Status.Value);
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/user/{userId}/notifications",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<FindNotificationResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MercoaException("Failed to deserialize response", e);
            }
        }

        throw new MercoaApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    public async Task<NotificationResponse> GetAsync(
        string entityId,
        string userId,
        string notificationId,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/user/{userId}/notification/{notificationId}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<NotificationResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MercoaException("Failed to deserialize response", e);
            }
        }

        throw new MercoaApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Update the status of a notification.
    /// </summary>
    public async Task<NotificationResponse> UpdateAsync(
        string entityId,
        string userId,
        string notificationId,
        NotificationUpdateRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Put,
                Path = $"/entity/{entityId}/user/{userId}/notification/{notificationId}",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<NotificationResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MercoaException("Failed to deserialize response", e);
            }
        }

        throw new MercoaApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
