using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Entity.Counterparty;

public partial class VendorCreditClient
{
    private RawClient _client;

    internal VendorCreditClient(RawClient client)
    {
        _client = client;
    }

    public async Task<FindVendorCreditResponse> GetAllAsync(
        string entityId,
        string counterpartyId,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/counterparty/{counterpartyId}/vendor-credits",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<FindVendorCreditResponse>(responseBody)!;
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

    public async Task<VendorCreditResponse> GetAsync(
        string entityId,
        string counterpartyId,
        string vendorCreditId,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path =
                    $"/entity/{entityId}/counterparty/{counterpartyId}/vendor-credit/{vendorCreditId}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<VendorCreditResponse>(responseBody)!;
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

    public async Task<VendorCreditResponse> CreateAsync(
        string entityId,
        string counterpartyId,
        VendorCreditRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/counterparty/{counterpartyId}/vendor-credit",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<VendorCreditResponse>(responseBody)!;
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

    public async Task DeleteAsync(
        string entityId,
        string counterpartyId,
        string vendorCreditId,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Delete,
                Path =
                    $"/entity/{entityId}/counterparty/{counterpartyId}/vendor-credit/{vendorCreditId}",
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
    /// Estimate the usage of vendor credits on an invoice of a given amount
    /// </summary>
    public async Task<CalculateVendorCreditUsageResponse> EstimateUsageAsync(
        string entityId,
        string counterpartyId,
        CalculateVendorCreditUsageRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["amount"] = request.Amount.ToString();
        if (request.Currency != null)
        {
            _query["currency"] = JsonSerializer.Serialize(request.Currency.Value);
        }
        if (request.ExcludedInvoiceIds != null)
        {
            _query["excludedInvoiceIds"] = request.ExcludedInvoiceIds.ToString();
        }
        if (request.IncludedVendorCreditIds != null)
        {
            _query["includedVendorCreditIds"] = request.IncludedVendorCreditIds.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path =
                    $"/entity/{entityId}/counterparty/{counterpartyId}/vendor-credits/estimate-usage",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<CalculateVendorCreditUsageResponse>(responseBody)!;
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
