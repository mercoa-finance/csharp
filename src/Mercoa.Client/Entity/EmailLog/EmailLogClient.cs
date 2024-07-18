using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;
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
            _query["startDate"] = request.StartDate.Value.ToString("o0");
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate.Value.ToString("o0");
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
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
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/emailLogs",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<EmailLogResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get an email log by ID
    /// </summary>
    public async Task<EmailLog> GetAsync(string entityId, string logId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/emailLog/{logId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<EmailLog>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
