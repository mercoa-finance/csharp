using System.Net.Http;
using System.Threading.Tasks;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Invoice;

public partial class ApprovalClient
{
    private RawClient _client;

    internal ApprovalClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Adds an approver to the invoice. Will select the first available approver slot that is not already filled and assign the approver to it. If no approver slots are available, an error will be returned. An explicit approver slot can be specified by setting the `approverSlot` field.
    /// </summary>
    public async Task AddApproverAsync(
        string invoiceId,
        AddApproverRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = $"/invoice/{invoiceId}/add-approver",
                Body = request,
                Options = options
            }
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new MercoaApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    public async Task ApproveAsync(
        string invoiceId,
        ApprovalRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = $"/invoice/{invoiceId}/approve",
                Body = request,
                Options = options
            }
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new MercoaApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    public async Task RejectAsync(
        string invoiceId,
        ApprovalRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = $"/invoice/{invoiceId}/reject",
                Body = request,
                Options = options
            }
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new MercoaApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
