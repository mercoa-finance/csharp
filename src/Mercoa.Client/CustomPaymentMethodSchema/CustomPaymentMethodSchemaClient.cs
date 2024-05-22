using System.Text.Json;
using Mercoa.Client;

namespace Mercoa.Client;

public class CustomPaymentMethodSchemaClient
{
    private RawClient _client;

    public CustomPaymentMethodSchemaClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get all custom payment method schemas
    /// </summary>
    public async Task<List<CustomPaymentMethodSchemaResponse>> GetAllAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/schema" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<List<CustomPaymentMethodSchemaResponse>>(
                responseBody
            );
        }
        throw new Exception();
    }

    /// <summary>
    /// Create custom payment method schema
    /// </summary>
    public async Task<CustomPaymentMethodSchemaResponse> CreateAsync(
        CustomPaymentMethodSchemaRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/schema",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CustomPaymentMethodSchemaResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Update custom payment method schema
    /// </summary>
    public async Task<CustomPaymentMethodSchemaResponse> UpdateAsync(
        string schemaId,
        CustomPaymentMethodSchemaRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/schema/{schemaId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CustomPaymentMethodSchemaResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Get custom payment method schema
    /// </summary>
    public async Task<CustomPaymentMethodSchemaResponse> GetAsync(string schemaId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/schema/{schemaId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CustomPaymentMethodSchemaResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Delete custom payment method schema. Schema that have been used in an invoice cannot be deleted.
    /// </summary>
    public async void DeleteAsync(string schemaId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/schema/{schemaId}" }
        );
    }
}
