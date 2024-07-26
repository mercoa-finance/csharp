using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;
using Mercoa.Client.Entity;

#nullable enable

namespace Mercoa.Client.Entity;

public class CounterpartyClient
{
    private RawClient _client;

    public CounterpartyClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Find payee counterparties. This endpoint lets you find vendors linked to the entity.
    /// </summary>
    public async Task<FindCounterpartiesResponse> FindPayeesAsync(
        string entityId,
        FindPayeeCounterpartiesRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Name != null)
        {
            _query["name"] = request.Name;
        }
        if (request.NetworkType != null)
        {
            _query["networkType"] = JsonSerializer.Serialize(request.NetworkType.Value);
        }
        if (request.PaymentMethods != null)
        {
            _query["paymentMethods"] = request.PaymentMethods.ToString();
        }
        if (request.InvoiceMetrics != null)
        {
            _query["invoiceMetrics"] = request.InvoiceMetrics.ToString();
        }
        if (request.CounterpartyId != null)
        {
            _query["counterpartyId"] = request.CounterpartyId;
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
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/counterparties/payees",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<FindCounterpartiesResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Find payor counterparties. This endpoint lets you find customers linked to the entity.
    /// </summary>
    public async Task<FindCounterpartiesResponse> FindPayorsAsync(
        string entityId,
        FindPayorCounterpartiesRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Name != null)
        {
            _query["name"] = request.Name;
        }
        if (request.NetworkType != null)
        {
            _query["networkType"] = JsonSerializer.Serialize(request.NetworkType.Value);
        }
        if (request.PaymentMethods != null)
        {
            _query["paymentMethods"] = request.PaymentMethods.ToString();
        }
        if (request.InvoiceMetrics != null)
        {
            _query["invoiceMetrics"] = request.InvoiceMetrics.ToString();
        }
        if (request.CounterpartyId != null)
        {
            _query["counterpartyId"] = request.CounterpartyId;
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
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/counterparties/payors",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<FindCounterpartiesResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Create association between Entity and a given list of Payees. If a Payee has previously been archived, unarchive the Payee.
    /// </summary>
    public async Task AddPayeesAsync(string entityId, EntityAddPayeesRequest request)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/addPayees",
                Body = request
            }
        );
    }

    /// <summary>
    /// Marks Payees as unsearchable by Entity via Counterparty search. Invoices associated with these Payees will still be searchable via Invoice search.
    /// </summary>
    public async Task HidePayeesAsync(string entityId, EntityHidePayeesRequest request)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/hidePayees",
                Body = request
            }
        );
    }

    /// <summary>
    /// Create association between Entity and a given list of Payors. If a Payor has previously been archived, unarchive the Payor.
    /// </summary>
    public async Task AddPayorsAsync(string entityId, EntityAddPayorsRequest request)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/addPayors",
                Body = request
            }
        );
    }

    /// <summary>
    /// Marks Payors as unsearchable by Entity via Counterparty search. Invoices associated with these Payors will still be searchable via Invoice search.
    /// </summary>
    public async Task HidePayorsAsync(string entityId, EntityHidePayorsRequest request)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/hidePayors",
                Body = request
            }
        );
    }
}
