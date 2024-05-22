using System.Text.Json;
using Mercoa.Client;

namespace Mercoa.Client;

public class FeesClient
{
    private RawClient _client;

    public FeesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Calculate the fees associated with an payment given the amount, payment source, and disbursement method. Can be used to calculate fees for a payment before creating an invoice.
    /// </summary>
    public async Task<InvoiceFeesResponse> CalculateAsync(CalculateFeesRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/fees",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<InvoiceFeesResponse>(responseBody);
        }
        throw new Exception();
    }
}
