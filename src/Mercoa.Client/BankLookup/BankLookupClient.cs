using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public class BankLookupClient
{
    private RawClient _client;

    public BankLookupClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Find bank account details
    /// </summary>
    public async Task<BankLookupResponse> FindAsync(BankLookupRequest request)
    {
        var _query = new Dictionary<string, object>()
        {
            { "routingNumber", request.RoutingNumber },
        };
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "bankLookup",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<BankLookupResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
