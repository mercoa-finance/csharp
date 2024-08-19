using System.Net.Http;
using System.Text.Json;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public partial class PaymentMethodsClient
{
    private RawClient _client;

    internal PaymentMethodsClient(RawClient client)
    {
        _client = client;
    }

    public async Task<PaymentMethodWithEntityFindResponse> FindAsync(
        FindPaymentMethodsRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["type"] = request.Type.Select(_value => _value.ToString()).ToList();
        _query["entityId"] = request.EntityId;
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
                Path = "paymentMethods",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PaymentMethodWithEntityFindResponse>(responseBody)!;
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
