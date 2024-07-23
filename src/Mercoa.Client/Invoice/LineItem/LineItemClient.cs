using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Invoice.LineItem;

public class LineItemClient
{
    private RawClient _client;

    public LineItemClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Update invoice line item
    /// </summary>
    public async Task<InvoiceResponse> UpdateAsync(
        string invoiceId,
        string lineItemId,
        InvoiceLineItemIndividualUpdateRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Put,
                Path = $"/invoice/{invoiceId}/line-item/{lineItemId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<InvoiceResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
