using System.Text.Json;
using Mercoa.Client;

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
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/bankLookup",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<BankLookupResponse>(responseBody);
        }
        throw new Exception();
    }
}
