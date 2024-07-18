using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;
using Mercoa.Client.Invoice;

#nullable enable

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
            _query["startDate"] = request.StartDate.Value.ToString("o0");
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate.Value.ToString("o0");
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
                Path = "invoices",
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

    public async Task<InvoiceResponse> CreateAsync(InvoiceCreationRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "invoice",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<InvoiceResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<InvoiceResponse> GetAsync(string invoiceId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest { Method = HttpMethod.Get, Path = $"invoice/{invoiceId}" }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<InvoiceResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<InvoiceResponse> UpdateAsync(string invoiceId, InvoiceUpdateRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"invoice/{invoiceId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<InvoiceResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Only invoices in the DRAFT and NEW status can be deleted.
    /// </summary>
    public async Task DeleteAsync(string invoiceId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"invoice/{invoiceId}"
            }
        );
    }
}
