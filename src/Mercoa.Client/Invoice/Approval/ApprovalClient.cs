using Mercoa.Client;

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
    public async void AddApproverAsync(AddApproverRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/add-approver",
                Body = request
            }
        );
    }

    public async void ApproveAsync(ApprovalRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/approve",
                Body = request
            }
        );
    }

    public async void RejectAsync(ApprovalRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/reject",
                Body = request
            }
        );
    }
}
