using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Entity.EmailLog;

public partial class EmailLogClient
{
    private RawClient _client;

    internal EmailLogClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get all incoming invoice emails for an entity.
    /// </summary>
    public async Task<EmailLogResponse> FindAsync(
        string entityId,
        EntityEmailLogRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.StartDate != null)
        {
            _query["startDate"] = request.StartDate.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate.Value.ToString(Constants.DateTimeFormat);
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
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/emailLogs",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<EmailLogResponse>(responseBody)!;
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
    /// Get an email log by ID
    /// </summary>
    public async Task<EmailLog> GetAsync(
        string entityId,
        string logId,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/emailLog/{logId}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<EmailLog>(responseBody)!;
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
