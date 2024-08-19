using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Entity.User;

public partial class NotificationPolicyClient
{
    private RawClient _client;

    internal NotificationPolicyClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieve all notification policies associated with this entity user
    /// </summary>
    public async Task<IEnumerable<UserNotificationPolicyResponse>> GetAllAsync(
        string entityId,
        string userId,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/user/{userId}/notification-policies",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<UserNotificationPolicyResponse>>(
                    responseBody
                )!;
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
    /// Retrieve notification policy associated with this entity user
    /// </summary>
    public async Task<UserNotificationPolicyResponse> GetAsync(
        string entityId,
        string userId,
        NotificationType notificationType,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/user/{userId}/notification-policy/{notificationType}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<UserNotificationPolicyResponse>(responseBody)!;
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
    /// Update notification policy associated with this entity user
    /// </summary>
    public async Task<UserNotificationPolicyResponse> UpdateAsync(
        string entityId,
        string userId,
        NotificationType notificationType,
        UserNotificationPolicyRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/user/{userId}/notification-policy/{notificationType}",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<UserNotificationPolicyResponse>(responseBody)!;
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
