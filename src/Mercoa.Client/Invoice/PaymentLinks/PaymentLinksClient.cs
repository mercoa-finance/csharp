using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Invoice;

#nullable enable

namespace Mercoa.Client.Invoice;

public class PaymentLinksClient
{
    private RawClient _client;

    public PaymentLinksClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get temporary link for payer to send payment
    /// </summary>
    public async Task<string> GetPayerLinkAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/payerLink" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<string>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Trigger email to payer inviting them to make payment
    /// </summary>
    public async void SendPayerEmailAsync(SendPayerEmail request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.AttachInvoice != null)
        {
            _query["attachInvoice"] = request.AttachInvoice;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/sendPayerEmail",
                Query = _query
            }
        );
    }

    /// <summary>
    /// Get temporary link for vendor to accept payment
    /// </summary>
    public async Task<string> GetVendorLinkAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/vendorLink" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<string>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Trigger email to vendor inviting them into the vendor portal
    /// </summary>
    public async void SendVendorEmailAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Post, Path = "/sendVendorEmail" }
        );
    }
}
