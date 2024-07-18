using System.Net.Http;
using System.Text.Json;
using Mercoa.Client.Core;
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
    /// Get the external accounting system connected to an entity
    /// </summary>
    public async Task<object> GetAsync(string entityId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/external-accounting-system"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<object>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Create/Link an entity to an external accounting system like Codat or Rutter. If the entity is already linked to an external accounting system, this will return the existing connection.
    /// </summary>
    public async Task<object> CreateAsync(string entityId, object request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/external-accounting-system/create",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<object>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get a link to connect an entity to an external accounting system like Quickbooks or Xero
    /// </summary>
    public async Task<string> ConnectAsync(string entityId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/external-accounting-system/connect"
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
    /// Sync an entity with an external accounting system. Will sync customers/vendors and invoices.
    /// </summary>
    public async Task SyncAsync(string entityId, SyncExternalSystemRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Vendors != null)
        {
            _query["vendors"] = JsonSerializer.Serialize(request.Vendors.Value);
        }
        if (request.Bills != null)
        {
            _query["bills"] = JsonSerializer.Serialize(request.Bills.Value);
        }
        if (request.GlAccounts != null)
        {
            _query["glAccounts"] = JsonSerializer.Serialize(request.GlAccounts.Value);
        }
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/external-accounting-system/sync",
                Query = _query
            }
        );
    }
}
