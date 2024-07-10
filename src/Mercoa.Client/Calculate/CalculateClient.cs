using System.Text.Json;
using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class CalculateClient
{
    private RawClient _client;

    public CalculateClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Calculate the estimated fees associated with an payment given the amount, payment source, and disbursement method. Can be used to calculate fees for a payment before creating an invoice.
    /// </summary>
    public async Task<InvoiceFeesResponse> FeeAsync(CalculateFeesRequest request)
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
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Calculate the estimated payment timing given the deduction date, payment source, and disbursement method. Can be used to calculate timing for a payment.
    /// </summary>
    public async Task<CalculatePaymentTimingResponse> PaymentTimingAsync(
        CalculatePaymentTimingRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/paymentTiming",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CalculatePaymentTimingResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
