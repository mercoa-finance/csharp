using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;
using Mercoa.Client.Entity;

#nullable enable

namespace Mercoa.Client.Entity;

public class InvoiceClient
{
    private RawClient _client;

    public InvoiceClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get invoices for an entity with the given filters.
    /// </summary>
    public async Task<FindInvoiceResponse> FindAsync(
        string entityId,
        EntityGetInvoicesRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
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
            _query["startDate"] = request.StartDate.Value.ToString("o0");
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate.Value.ToString("o0");
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
        if (request.Metadata != null)
        {
            _query["metadata"] = request.Metadata.ToString();
        }
        if (request.LineItemMetadata != null)
        {
            _query["lineItemMetadata"] = request.LineItemMetadata.ToString();
        }
        if (request.LineItemGlAccountId != null)
        {
            _query["lineItemGlAccountId"] = request.LineItemGlAccountId;
        }
        if (request.Search != null)
        {
            _query["search"] = request.Search;
        }
        if (request.PayerId != null)
        {
            _query["payerId"] = request.PayerId;
        }
        if (request.VendorId != null)
        {
            _query["vendorId"] = request.VendorId;
        }
        if (request.ApproverId != null)
        {
            _query["approverId"] = request.ApproverId;
        }
        if (request.ApproverAction != null)
        {
            _query["approverAction"] = JsonSerializer.Serialize(request.ApproverAction.Value);
        }
        if (request.InvoiceId != null)
        {
            _query["invoiceId"] = request.InvoiceId;
        }
        if (request.Status != null)
        {
            _query["status"] = JsonSerializer.Serialize(request.Status.Value);
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/invoices",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<FindInvoiceResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get invoice metrics for an entity with the given filters. Invoices will be grouped by currency. If none of excludePayables, excludeReceivables, payerId, vendorId, or invoiceId status filters are provided, excludeReceivables will be set to true.
    /// </summary>
    public async Task<IEnumerable<InvoiceMetricsResponse>> MetricsAsync(
        string entityId,
        InvoiceMetricsRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
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
        if (request.PayerId != null)
        {
            _query["payerId"] = request.PayerId;
        }
        if (request.VendorId != null)
        {
            _query["vendorId"] = request.VendorId;
        }
        if (request.ApproverId != null)
        {
            _query["approverId"] = request.ApproverId;
        }
        if (request.InvoiceId != null)
        {
            _query["invoiceId"] = request.InvoiceId;
        }
        if (request.Status != null)
        {
            _query["status"] = JsonSerializer.Serialize(request.Status.Value);
        }
        if (request.StartDate != null)
        {
            _query["startDate"] = request.StartDate.Value.ToString("o0");
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate.Value.ToString("o0");
        }
        if (request.DateType != null)
        {
            _query["dateType"] = JsonSerializer.Serialize(request.DateType.Value);
        }
        if (request.DueDateStart != null)
        {
            _query["dueDateStart"] = request.DueDateStart.Value.ToString("o0");
        }
        if (request.DueDateEnd != null)
        {
            _query["dueDateEnd"] = request.DueDateEnd.Value.ToString("o0");
        }
        if (request.CreatedDateStart != null)
        {
            _query["createdDateStart"] = request.CreatedDateStart.Value.ToString("o0");
        }
        if (request.CreatedDateEnd != null)
        {
            _query["createdDateEnd"] = request.CreatedDateEnd.Value.ToString("o0");
        }
        if (request.Currency != null)
        {
            _query["currency"] = JsonSerializer.Serialize(request.Currency.Value);
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/invoice-metrics",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<InvoiceMetricsResponse>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
