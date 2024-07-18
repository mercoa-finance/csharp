using System.Net.Http;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Invoice;

public class ApprovalClient
{
    private RawClient _client;

    public ApprovalClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Adds an approver to the invoice. Will select the first available approver slot that is not already filled and assign the approver to it. If no approver slots are available, an error will be returned. An explicit approver slot can be specified by setting the `approverSlot` field.
    /// </summary>
    public async Task AddApproverAsync(string invoiceId, AddApproverRequest request)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/invoice/{invoiceId}/add-approver",
                Body = request
            }
        );
    }

    public async Task ApproveAsync(string invoiceId, ApprovalRequest request)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/invoice/{invoiceId}/approve",
                Body = request
            }
        );
    }

    public async Task RejectAsync(string invoiceId, ApprovalRequest request)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/invoice/{invoiceId}/reject",
                Body = request
            }
        );
    }
}
