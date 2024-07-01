using System.Text.Json;
using Mercoa.Client;
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

    public async Task<IEnumerable<PaymentMethodResponse>> GetAllAsync(
        GetAllPaymentMethodsRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Type != null)
        {
            _query["type"] = request.Type;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/paymentMethods",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<PaymentMethodResponse>>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<PaymentMethodResponse> CreateAsync(PaymentMethodRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/paymentMethod",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaymentMethodResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<PaymentMethodResponse> GetAsync(string paymentMethodId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/paymentMethod/{paymentMethodId}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaymentMethodResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Only custom payment methods can be updated.
    /// </summary>
    public async Task<PaymentMethodResponse> UpdateAsync(
        string paymentMethodId,
        PaymentMethodUpdateRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Put,
                Path = $"/paymentMethod/{paymentMethodId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaymentMethodResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Mark a payment method as inactive. This will not remove the payment method from the system, but will prevent it from being used in the future.
    /// </summary>
    public async void DeleteAsync(string paymentMethodId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/paymentMethod/{paymentMethodId}"
            }
        );
    }

    /// <summary>
    /// Initiate micro deposits for a bank account
    /// </summary>
    public async Task<PaymentMethodResponse> InitiateMicroDepositsAsync(string paymentMethodId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/paymentMethod/{paymentMethodId}/micro-deposits"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaymentMethodResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Complete micro deposit verification
    /// </summary>
    public async Task<PaymentMethodResponse> CompleteMicroDepositsAsync(
        string paymentMethodId,
        CompleteMicroDepositsRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Put,
                Path = $"/paymentMethod/{paymentMethodId}/micro-deposits",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaymentMethodResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deprecated. Get the available balance of a payment method. Only bank accounts added with Plaid are supported. This endpoint will return a cached value and will refresh the balance when called.
    /// </summary>
    public async Task<PaymentMethodBalanceResponse> GetBalanceAsync(string paymentMethodId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/paymentMethod/{paymentMethodId}/balance"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaymentMethodBalanceResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
