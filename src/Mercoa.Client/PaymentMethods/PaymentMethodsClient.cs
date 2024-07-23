using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public class PaymentMethodsClient
{
    private RawClient _client;

    public PaymentMethodsClient(RawClient client)
    {
        _client = client;
    }

    public async Task<PaymentMethodWithEntityFindResponse> FindAsync(
        FindPaymentMethodsRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.StartingAfter != null)
        {
            _query["startingAfter"] = request.StartingAfter;
        }
        if (request.Type != null)
        {
            _query["type"] = JsonSerializer.Serialize(request.Type.Value);
        }
        if (request.EntityId != null)
        {
            _query["entityId"] = request.EntityId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "paymentMethods",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<PaymentMethodWithEntityFindResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
