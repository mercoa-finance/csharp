using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Entity;

public partial class InvoiceClient
{
    private RawClient _client;

    internal InvoiceClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get invoices for an entity with the given filters.
    /// </summary>
    public async Task<FindInvoiceResponse> FindAsync(
        string entityId,
        EntityGetInvoicesRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["metadata"] = request.Metadata.Select(_value => _value.ToString()).ToList();
        _query["lineItemMetadata"] = request
            .LineItemMetadata.Select(_value => _value.ToString())
            .ToList();
        _query["lineItemGlAccountId"] = request.LineItemGlAccountId;
        _query["payerId"] = request.PayerId;
        _query["vendorId"] = request.VendorId;
        _query["creatorUserId"] = request.CreatorUserId;
        _query["approverId"] = request.ApproverId;
        _query["approverAction"] = request
            .ApproverAction.Select(_value => _value.ToString())
            .ToList();
        _query["invoiceId"] = request.InvoiceId;
        _query["status"] = request.Status.Select(_value => _value.ToString()).ToList();
        if (request.ExcludePayables != null)
        {
            _query["excludePayables"] = request.ExcludePayables.ToString();
        }
        if (request.ExcludeReceivables != null)
        {
            _query["excludeReceivables"] = request.ExcludeReceivables.ToString();
        }
        if (request.StartDate != null)
        {
            _query["startDate"] = request.StartDate.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.DateType != null)
        {
            _query["dateType"] = JsonSerializer.Serialize(request.DateType.Value);
        }
        if (request.OrderBy != null)
        {
            _query["orderBy"] = JsonSerializer.Serialize(request.OrderBy.Value);
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
        if (request.Search != null)
        {
            _query["search"] = request.Search;
        }
        if (request.PaymentType != null)
        {
            _query["paymentType"] = request.PaymentType.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/invoices",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<FindInvoiceResponse>(responseBody)!;
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
    /// Get invoice metrics for an entity with the given filters. Invoices will always be grouped by currency. If none of excludePayables, excludeReceivables, payerId, vendorId, or invoiceId status filters are provided, excludeReceivables will be set to true.
    /// </summary>
    public async Task<IEnumerable<InvoiceMetricsResponse>> MetricsAsync(
        string entityId,
        InvoiceMetricsRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["groupBy"] = request.GroupBy.Select(_value => _value.ToString()).ToList();
        _query["payerId"] = request.PayerId;
        _query["vendorId"] = request.VendorId;
        _query["approverId"] = request.ApproverId;
        _query["invoiceId"] = request.InvoiceId;
        _query["status"] = request.Status.Select(_value => _value.ToString()).ToList();
        _query["currency"] = request.Currency.Select(_value => _value.ToString()).ToList();
        if (request.Search != null)
        {
            _query["search"] = request.Search;
        }
        if (request.ExcludePayables != null)
        {
            _query["excludePayables"] = request.ExcludePayables.ToString();
        }
        if (request.ExcludeReceivables != null)
        {
            _query["excludeReceivables"] = request.ExcludeReceivables.ToString();
        }
        if (request.ReturnByDate != null)
        {
            _query["returnByDate"] = JsonSerializer.Serialize(request.ReturnByDate.Value);
        }
        if (request.ReturnByDateFrequency != null)
        {
            _query["returnByDateFrequency"] = JsonSerializer.Serialize(
                request.ReturnByDateFrequency.Value
            );
        }
        if (request.StartDate != null)
        {
            _query["startDate"] = request.StartDate.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.DateType != null)
        {
            _query["dateType"] = JsonSerializer.Serialize(request.DateType.Value);
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/invoice-metrics",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<InvoiceMetricsResponse>>(responseBody)!;
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
