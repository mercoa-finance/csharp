using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Entity;

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
    public async Task<FindInvoiceResponse> FindAsync(EntityGetInvoicesRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.ExcludePayables != null)
        {
            _query["excludePayables"] = request.ExcludePayables;
        }
        if (request.ExcludeReceivables != null)
        {
            _query["excludeReceivables"] = request.ExcludeReceivables;
        }
        if (request.StartDate != null)
        {
            _query["startDate"] = request.StartDate;
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate;
        }
        if (request.OrderBy != null)
        {
            _query["orderBy"] = request.OrderBy;
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
        if (request.Metadata != null)
        {
            _query["metadata"] = request.Metadata;
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
            _query["approverAction"] = request.ApproverAction;
        }
        if (request.InvoiceId != null)
        {
            _query["invoiceId"] = request.InvoiceId;
        }
        if (request.Status != null)
        {
            _query["status"] = request.Status;
        }
        if (request.IncludeFees != null)
        {
            _query["includeFees"] = request.IncludeFees;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/invoices",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<FindInvoiceResponse>(responseBody);
        }
        throw new Exception();
    }

    public async Task<InvoiceResponse> GetAsync(string invoiceId, GetInvoice request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IncludeFees != null)
        {
            _query["includeFees"] = request.IncludeFees;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/invoice/{invoiceId}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<InvoiceResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Get invoice metrics for an entity with the given filters. Invoices will be grouped by currency. If none of excludePayables, excludeReceivables, payerId, vendorId, or invoiceId status filters are provided, excludeReceivables will be set to true.
    /// </summary>
    public async Task<List<InvoiceMetricsResponse>> MetricsAsync(InvoiceMetricsRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Search != null)
        {
            _query["search"] = request.Search;
        }
        if (request.ExcludePayables != null)
        {
            _query["excludePayables"] = request.ExcludePayables;
        }
        if (request.ExcludeReceivables != null)
        {
            _query["excludeReceivables"] = request.ExcludeReceivables;
        }
        if (request.ReturnByDate != null)
        {
            _query["returnByDate"] = request.ReturnByDate;
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
            _query["status"] = request.Status;
        }
        if (request.DueDateStart != null)
        {
            _query["dueDateStart"] = request.DueDateStart;
        }
        if (request.DueDateEnd != null)
        {
            _query["dueDateEnd"] = request.DueDateEnd;
        }
        if (request.CreatedDateStart != null)
        {
            _query["createdDateStart"] = request.CreatedDateStart;
        }
        if (request.CreatedDateEnd != null)
        {
            _query["createdDateEnd"] = request.CreatedDateEnd;
        }
        if (request.Currency != null)
        {
            _query["currency"] = request.Currency;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/invoice-metrics",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<List<InvoiceMetricsResponse>>(responseBody);
        }
        throw new Exception();
    }
}
