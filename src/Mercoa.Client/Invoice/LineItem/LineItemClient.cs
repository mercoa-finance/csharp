using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Invoice.LineItem;

public partial class LineItemClient
{
    private RawClient _client;

    internal LineItemClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Update invoice line item
    /// </summary>
    public async Task<InvoiceResponse> UpdateAsync(
        string invoiceId,
        string lineItemId,
        InvoiceLineItemIndividualUpdateRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Put,
                Path = $"/invoice/{invoiceId}/line-item/{lineItemId}",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InvoiceResponse>(responseBody)!;
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
