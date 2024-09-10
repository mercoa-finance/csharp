using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Entity;

public partial class CounterpartyClient
{
    private RawClient _client;

    internal CounterpartyClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Find payee counterparties. This endpoint lets you find vendors linked to the entity.
    /// </summary>
    public async Task<FindCounterpartiesResponse> FindPayeesAsync(
        string entityId,
        FindPayeeCounterpartiesRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["networkType"] = request.NetworkType.Select(_value => _value.ToString()).ToList();
        _query["counterpartyId"] = request.CounterpartyId;
        if (request.Name != null)
        {
            _query["name"] = request.Name;
        }
        if (request.PaymentMethods != null)
        {
            _query["paymentMethods"] = request.PaymentMethods.ToString();
        }
        if (request.InvoiceMetrics != null)
        {
            _query["invoiceMetrics"] = request.InvoiceMetrics.ToString();
        }
        if (request.Metadata != null)
        {
            _query["metadata"] = request.Metadata.ToString();
        }
        if (request.ReturnMetadata != null)
        {
            _query["returnMetadata"] = request.ReturnMetadata.ToString();
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.StartingAfter != null)
        {
            _query["startingAfter"] = request.StartingAfter;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/counterparties/payees",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<FindCounterpartiesResponse>(responseBody)!;
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
    /// Find payor counterparties. This endpoint lets you find customers linked to the entity.
    /// </summary>
    public async Task<FindCounterpartiesResponse> FindPayorsAsync(
        string entityId,
        FindPayorCounterpartiesRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["networkType"] = request.NetworkType.Select(_value => _value.ToString()).ToList();
        _query["counterpartyId"] = request.CounterpartyId;
        if (request.Name != null)
        {
            _query["name"] = request.Name;
        }
        if (request.PaymentMethods != null)
        {
            _query["paymentMethods"] = request.PaymentMethods.ToString();
        }
        if (request.InvoiceMetrics != null)
        {
            _query["invoiceMetrics"] = request.InvoiceMetrics.ToString();
        }
        if (request.Metadata != null)
        {
            _query["metadata"] = request.Metadata.ToString();
        }
        if (request.ReturnMetadata != null)
        {
            _query["returnMetadata"] = request.ReturnMetadata.ToString();
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.StartingAfter != null)
        {
            _query["startingAfter"] = request.StartingAfter;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/counterparties/payors",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<FindCounterpartiesResponse>(responseBody)!;
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
    /// Create association between Entity and a given list of Payees. If a Payee has previously been archived, unarchive the Payee.
    /// </summary>
    public async Task AddPayeesAsync(
        string entityId,
        EntityAddPayeesRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/addPayees",
                Body = request,
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
    /// Marks Payees as unsearchable by Entity via Counterparty search. Invoices associated with these Payees will still be searchable via Invoice search.
    /// </summary>
    public async Task HidePayeesAsync(
        string entityId,
        EntityHidePayeesRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/hidePayees",
                Body = request,
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
    /// Create association between Entity and a given list of Payors. If a Payor has previously been archived, unarchive the Payor.
    /// </summary>
    public async Task AddPayorsAsync(
        string entityId,
        EntityAddPayorsRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/addPayors",
                Body = request,
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
    /// Marks Payors as unsearchable by Entity via Counterparty search. Invoices associated with these Payors will still be searchable via Invoice search.
    /// </summary>
    public async Task HidePayorsAsync(
        string entityId,
        EntityHidePayorsRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/hidePayors",
                Body = request,
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
