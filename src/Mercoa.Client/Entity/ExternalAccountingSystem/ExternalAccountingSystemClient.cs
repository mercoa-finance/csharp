using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Entity;

#nullable enable

namespace Mercoa.Client.Entity;

public class ExternalAccountingSystemClient
{
    private RawClient _client;

    public ExternalAccountingSystemClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Create/Link an entity to an external accounting system like Codat or Rutter
    /// </summary>
    public async Task<ExternalAccountingSystemCompanyResponse> CreateAsync(
        ExternalAccountingSystemCompanyCreationRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/external-accounting-system/create",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ExternalAccountingSystemCompanyResponse>(
                responseBody
            );
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get a link to connect an entity to an external accounting system like Quickbooks or Xero
    /// </summary>
    public async Task<string> ConnectAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/external-accounting-system/connect"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<string>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Sync an entity with an external accounting system. Will sync customers/vendors and invoices.
    /// </summary>
    public async void SyncAsync(SyncExternalSystemRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Vendors != null)
        {
            _query["vendors"] = request.Vendors;
        }
        if (request.Bills != null)
        {
            _query["bills"] = request.Bills;
        }
        if (request.GlAccounts != null)
        {
            _query["glAccounts"] = request.GlAccounts;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/external-accounting-system/sync",
                Query = _query
            }
        );
    }
}
