using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;
using Mercoa.Client.Entity;

#nullable enable

namespace Mercoa.Client.Entity;

public class PaymentMethodClient
{
    private RawClient _client;

    public PaymentMethodClient(RawClient client)
    {
        _client = client;
    }

    public async Task<IEnumerable<object>> GetAllAsync(
        string entityId,
        GetAllPaymentMethodsRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Type != null)
        {
            _query["type"] = JsonSerializer.Serialize(request.Type.Value);
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/paymentMethods",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<object>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<object> CreateAsync(string entityId, object request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/paymentMethod",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<object>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<object> GetAsync(string entityId, string paymentMethodId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/paymentMethod/{paymentMethodId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<object>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Only custom payment methods can be updated.
    /// </summary>
    public async Task<object> UpdateAsync(string entityId, string paymentMethodId, object request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Put,
                Path = $"/entity/{entityId}/paymentMethod/{paymentMethodId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<object>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Mark a payment method as inactive. This will not remove the payment method from the system, but will prevent it from being used in the future.
    /// </summary>
    public async Task DeleteAsync(string entityId, string paymentMethodId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/entity/{entityId}/paymentMethod/{paymentMethodId}"
            }
        );
    }

    /// <summary>
    /// Initiate micro deposits for a bank account
    /// </summary>
    public async Task<object> InitiateMicroDepositsAsync(string entityId, string paymentMethodId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/paymentMethod/{paymentMethodId}/micro-deposits"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<object>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Complete micro deposit verification
    /// </summary>
    public async Task<object> CompleteMicroDepositsAsync(
        string entityId,
        string paymentMethodId,
        CompleteMicroDepositsRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Put,
                Path = $"/entity/{entityId}/paymentMethod/{paymentMethodId}/micro-deposits",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<object>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deprecated. Get the available balance of a payment method. Only bank accounts added with Plaid are supported. This endpoint will return a cached value and will refresh the balance when called.
    /// </summary>
    public async Task<PaymentMethodBalanceResponse> GetBalanceAsync(
        string entityId,
        string paymentMethodId
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/paymentMethod/{paymentMethodId}/balance"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<PaymentMethodBalanceResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
