using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Mercoa.Client;
using Mercoa.Client.Core;
using Mercoa.Client.Invoice.LineItem;
using OneOf;

#nullable enable

namespace Mercoa.Client.Invoice;

public partial class InvoiceClient
{
    private RawClient _client;

    internal InvoiceClient(RawClient client)
    {
        _client = client;
        LineItem = new LineItemClient(_client);
        Approval = new ApprovalClient(_client);
        Comment = new CommentClient(_client);
        Document = new DocumentClient(_client);
        PaymentLinks = new PaymentLinksClient(_client);
    }

    public LineItemClient LineItem { get; }

    public ApprovalClient Approval { get; }

    public CommentClient Comment { get; }

    public DocumentClient Document { get; }

    public PaymentLinksClient PaymentLinks { get; }

    /// <summary>
    /// Search invoices for all entities in the organization
    /// </summary>
    public async Task<FindInvoiceResponse> FindAsync(
        GetAllInvoicesRequest request,
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
        _query["approverId"] = request.ApproverId;
        _query["approverAction"] = request
            .ApproverAction.Select(_value => _value.ToString())
            .ToList();
        _query["invoiceId"] = request.InvoiceId;
        _query["status"] = request.Status.Select(_value => _value.ToString()).ToList();
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
                Path = "invoices",
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

    public async Task<InvoiceResponse> CreateAsync(
        OneOf<InvoiceCreationWithEntityRequest, InvoiceCreationWithEntityGroupRequest> request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "invoice",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InvoiceResponse>(responseBody)!;
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

    public async Task<InvoiceResponse> GetAsync(string invoiceId, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"invoice/{invoiceId}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InvoiceResponse>(responseBody)!;
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

    public async Task<InvoiceResponse> UpdateAsync(
        string invoiceId,
        InvoiceUpdateRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = $"invoice/{invoiceId}",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InvoiceResponse>(responseBody)!;
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
    /// Only invoices in the DRAFT and NEW status can be deleted.
    /// </summary>
    public async Task DeleteAsync(string invoiceId, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Delete,
                Path = $"invoice/{invoiceId}",
                Options = options
            }
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new MercoaApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Get all events for an invoice
    /// </summary>
    public async Task<InvoiceEventsResponse> EventsAsync(
        string invoiceId,
        InvoiceInvoiceGetEventsRequest request,
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
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"invoice/{invoiceId}/events",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InvoiceEventsResponse>(responseBody)!;
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
