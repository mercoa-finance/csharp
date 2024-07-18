using System.Net.Http;
using System.Text.Json;
using Mercoa.Client.Core;
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
    public async Task<string> GetPayerLinkAsync(string invoiceId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/invoice/{invoiceId}/payerLink"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<string>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Trigger email to payer inviting them to make payment
    /// </summary>
    public async Task SendPayerEmailAsync(string invoiceId, SendPayerEmail request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.AttachInvoice != null)
        {
            _query["attachInvoice"] = request.AttachInvoice.ToString();
        }
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/invoice/{invoiceId}/sendPayerEmail",
                Query = _query
            }
        );
    }

    /// <summary>
    /// Get temporary link for vendor to accept payment
    /// </summary>
    public async Task<string> GetVendorLinkAsync(string invoiceId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/invoice/{invoiceId}/vendorLink"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<string>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Trigger email to vendor inviting them into the vendor portal
    /// </summary>
    public async Task SendVendorEmailAsync(string invoiceId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/invoice/{invoiceId}/sendVendorEmail"
            }
        );
    }
}
