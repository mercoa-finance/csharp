using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Invoice;

namespace Mercoa.Client.Invoice;

public class InvoiceClient
{
    private RawClient _client;

    public InvoiceClient(RawClient client)
    {
        _client = client;
        Approval = new ApprovalClient(_client);
        Comment = new CommentClient(_client);
        Document = new DocumentClient(_client);
        PaymentLinks = new PaymentLinksClient(_client);
    }

    public ApprovalClient Approval { get; }

    public CommentClient Comment { get; }

    public DocumentClient Document { get; }

    public PaymentLinksClient PaymentLinks { get; }

    /// <summary>
    /// Search invoices for all entities in the organization
    /// </summary>
    public async Task<FindInvoiceResponse> FindAsync(GetAllInvoicesRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.EntityId != null)
        {
            _query["entityId"] = request.EntityId;
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
        if (request.Search != null)
        {
            _query["search"] = request.Search;
        }
        if (request.Metadata != null)
        {
            _query["metadata"] = request.Metadata;
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

    public async Task<InvoiceResponse> CreateAsync(InvoiceCreationRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/invoice",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<InvoiceResponse>(responseBody);
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

    public async Task<InvoiceResponse> UpdateAsync(string invoiceId, InvoiceUpdateRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/invoice/{invoiceId}",
                Body = request
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
    /// Only invoices in the DRAFT and NEW status can be deleted.
    /// </summary>
    public async void DeleteAsync(string invoiceId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/invoice/{invoiceId}" }
        );
    }
}
