using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Mercoa.Client;
using Mercoa.Client.Core;
using Mercoa.Client.InvoiceTemplate.LineItem;

#nullable enable

namespace Mercoa.Client.InvoiceTemplate;

public partial class InvoiceTemplateClient
{
    private RawClient _client;

    internal InvoiceTemplateClient(RawClient client)
    {
        _client = client;
        LineItem = new LineItemClient(_client);
        Approval = new ApprovalClient(_client);
        Document = new DocumentClient(_client);
    }

    public LineItemClient LineItem { get; }

    public ApprovalClient Approval { get; }

    public DocumentClient Document { get; }

    /// <summary>
    /// Search invoice templates for all entities in the organization
    /// </summary>
    public async Task<FindInvoiceTemplateResponse> FindAsync(
        GetAllInvoiceTemplatesRequest request,
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
        _query["creatorUserId"] = request.CreatorUserId;
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
                Path = "invoice-templates",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<FindInvoiceTemplateResponse>(responseBody)!;
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

    public async Task<InvoiceTemplateResponse> CreateAsync(
        InvoiceTemplateCreationRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "invoice-template",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InvoiceTemplateResponse>(responseBody)!;
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

    public async Task<InvoiceTemplateResponse> GetAsync(
        string invoiceTemplateId,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"invoice-template/{invoiceTemplateId}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InvoiceTemplateResponse>(responseBody)!;
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

    public async Task<InvoiceTemplateResponse> UpdateAsync(
        string invoiceTemplateId,
        InvoiceTemplateUpdateRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = $"invoice-template/{invoiceTemplateId}",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InvoiceTemplateResponse>(responseBody)!;
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
    /// Only invoice templates in the UNASSIGNED and DRAFT statuses can be deleted.
    /// </summary>
    public async Task DeleteAsync(string invoiceTemplateId, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Delete,
                Path = $"invoice-template/{invoiceTemplateId}",
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
}
