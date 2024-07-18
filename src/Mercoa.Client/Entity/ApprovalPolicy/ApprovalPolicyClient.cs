using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Entity;

public class ApprovalPolicyClient
{
    private RawClient _client;

    public ApprovalPolicyClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieve all invoice approval policies associated with an entity
    /// </summary>
    public async Task<IEnumerable<ApprovalPolicyResponse>> GetAllAsync(string entityId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/approval-policies"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<ApprovalPolicyResponse>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Create an invoice approval policy associated with an entity
    /// </summary>
    public async Task<ApprovalPolicyResponse> CreateAsync(
        string entityId,
        ApprovalPolicyRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/approval-policy",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<ApprovalPolicyResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Retrieve an invoice approval policy associated with an entity
    /// </summary>
    public async Task<ApprovalPolicyResponse> GetAsync(string entityId, string policyId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/approval-policy/{policyId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<ApprovalPolicyResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update an invoice approval policy associated with an entity
    /// </summary>
    public async Task<ApprovalPolicyResponse> UpdateAsync(
        string entityId,
        string policyId,
        ApprovalPolicyUpdateRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/approval-policy/{policyId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<ApprovalPolicyResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Delete an invoice approval policy associated with Entity. BEWARE: Any approval policy deletion will result in all associated downstream policies also being deleted.
    /// </summary>
    public async Task DeleteAsync(string entityId, string policyId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/entity/{entityId}/approval-policy/{policyId}"
            }
        );
    }
}
