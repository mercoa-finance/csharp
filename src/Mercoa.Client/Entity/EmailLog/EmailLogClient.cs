using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Entity.EmailLog;

#nullable enable

namespace Mercoa.Client.Entity.EmailLog;

public class EmailLogClient
{
    private RawClient _client;

    public EmailLogClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get all incoming invoice emails for an entity.
    /// </summary>
    public async Task<EmailLogResponse> FindAsync(string entityId, EntityEmailLogRequest request)
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
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit;
        }
        if (request.StartingAfter != null)
        {
            _query["startingAfter"] = request.StartingAfter;
        }
        if (request.Search != null)
        {
            _query["search"] = request.Search;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/{entityId}/emailLogs",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EmailLogResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get an email log by ID
    /// </summary>
    public async Task<EmailLog> GetAsync(string entityId, string logId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/{entityId}/emailLog/{logId}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EmailLog>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
