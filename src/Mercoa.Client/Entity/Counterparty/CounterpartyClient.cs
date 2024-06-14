using System.Text.Json;
using Mercoa.Client;
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
            _query["networkType"] = request.NetworkType;
        }
        if (request.PaymentMethods != null)
        {
            _query["paymentMethods"] = request.PaymentMethods;
        }
        if (request.InvoiceMetrics != null)
        {
            _query["invoiceMetrics"] = request.InvoiceMetrics;
        }
        if (request.Logo != null)
        {
            _query["logo"] = request.Logo;
        }
        if (request.CounterpartyId != null)
        {
            _query["counterpartyId"] = request.CounterpartyId;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit;
        }
        if (request.StartingAfter != null)
        {
            _query["startingAfter"] = request.StartingAfter;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/counterparties/payees",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<FindCounterpartiesResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Find payor counterparties. This endpoint lets you find customers linked to the entity.
    /// </summary>
    public async Task<FindCounterpartiesResponse> FindPayorsAsync(
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
            _query["networkType"] = request.NetworkType;
        }
        if (request.PaymentMethods != null)
        {
            _query["paymentMethods"] = request.PaymentMethods;
        }
        if (request.InvoiceMetrics != null)
        {
            _query["invoiceMetrics"] = request.InvoiceMetrics;
        }
        if (request.Logo != null)
        {
            _query["logo"] = request.Logo;
        }
        if (request.CounterpartyId != null)
        {
            _query["counterpartyId"] = request.CounterpartyId;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit;
        }
        if (request.StartingAfter != null)
        {
            _query["startingAfter"] = request.StartingAfter;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/counterparties/payors",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<FindCounterpartiesResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Create association between Entity and a given list of Payees. If a Payee has previously been archived, unarchive the Payee.
    /// </summary>
    public async void AddPayeesAsync(EntityAddPayeesRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/addPayees",
                Body = request
            }
        );
    }

    /// <summary>
    /// Marks Payees as unsearchable by Entity via Counterparty search. Invoices associated with these Payees will still be searchable via Invoice search.
    /// </summary>
    public async void HidePayeesAsync(EntityHidePayeesRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/hidePayees",
                Body = request
            }
        );
    }

    /// <summary>
    /// Create association between Entity and a given list of Payors. If a Payor has previously been archived, unarchive the Payor.
    /// </summary>
    public async void AddPayorsAsync(EntityAddPayorsRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/addPayors",
                Body = request
            }
        );
    }

    /// <summary>
    /// Marks Payors as unsearchable by Entity via Counterparty search. Invoices associated with these Payors will still be searchable via Invoice search.
    /// </summary>
    public async void HidePayorsAsync(EntityHidePayorsRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/hidePayors",
                Body = request
            }
        );
    }
}
