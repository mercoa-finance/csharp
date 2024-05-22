using System.Text.Json;
using Mercoa.Client;

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
    public async Task<List<ApprovalPolicyResponse>> GetAllAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/approval-policies" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<List<ApprovalPolicyResponse>>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Create an invoice approval policy associated with an entity
    /// </summary>
    public async Task<ApprovalPolicyResponse> CreateAsync(ApprovalPolicyRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/approval-policy",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ApprovalPolicyResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Retrieve an invoice approval policy associated with an entity
    /// </summary>
    public async Task<ApprovalPolicyResponse> GetAsync(string policyId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/approval-policy/{policyId}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ApprovalPolicyResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Update an invoice approval policy associated with an entity
    /// </summary>
    public async Task<ApprovalPolicyResponse> UpdateAsync(
        string policyId,
        ApprovalPolicyUpdateRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/approval-policy/{policyId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ApprovalPolicyResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Delete an invoice approval policy associated with Entity. BEWARE: Any approval policy deletion will result in all associated downstream policies also being deleted.
    /// </summary>
    public async void DeleteAsync(string policyId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/approval-policy/{policyId}"
            }
        );
    }
}
