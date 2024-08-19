using System.Net.Http;
using System.Text.Json;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public partial class BankLookupClient
{
    private RawClient _client;

    internal BankLookupClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Find bank account details
    /// </summary>
    public async Task<BankLookupResponse> FindAsync(
        BankLookupRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["routingNumber"] = request.RoutingNumber;
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "bankLookup",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<BankLookupResponse>(responseBody)!;
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
