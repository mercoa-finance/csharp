using System.Net.Http;
using System.Text.Json;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public partial class TransactionClient
{
    private RawClient _client;

    internal TransactionClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Search transactions
    /// </summary>
    public async Task<FindTransactionsResponse> FindAsync(
        FindTransactionsRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["entityId"] = request.EntityId;
        _query["metadata"] = request.Metadata.Select(_value => _value.ToString()).ToList();
        _query["lineItemMetadata"] = request
            .LineItemMetadata.Select(_value => _value.ToString())
            .ToList();
        _query["lineItemGlAccountId"] = request.LineItemGlAccountId;
        _query["payerId"] = request.PayerId;
        _query["vendorId"] = request.VendorId;
        _query["invoiceId"] = request.InvoiceId;
        _query["transactionId"] = request.TransactionId;
        _query["status"] = request.Status.Select(_value => _value.ToString()).ToList();
        _query["transactionType"] = request
            .TransactionType.Select(_value => _value.ToString())
            .ToList();
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
                Path = "transactions",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<FindTransactionsResponse>(responseBody)!;
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
    /// Get Transaction
    /// </summary>
    public async Task<object> GetAsync(string transactionId, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"transaction/{transactionId}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<object>(responseBody)!;
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
