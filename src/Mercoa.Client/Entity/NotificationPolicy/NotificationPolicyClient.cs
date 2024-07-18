using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

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
    public async Task<IEnumerable<NotificationPolicyResponse>> GetAllAsync(string entityId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/notification-policies"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<NotificationPolicyResponse>>(
                responseBody
            )!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Retrieve notification policy associated with this entity
    /// </summary>
    public async Task<NotificationPolicyResponse> GetAsync(
        string entityId,
        NotificationType notificationType
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/notification-policy/{notificationType}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<NotificationPolicyResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update notification policy associated with this entity
    /// </summary>
    public async Task<NotificationPolicyResponse> UpdateAsync(
        string entityId,
        NotificationType notificationType,
        NotificationPolicyRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/notification-policy/{notificationType}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<NotificationPolicyResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
