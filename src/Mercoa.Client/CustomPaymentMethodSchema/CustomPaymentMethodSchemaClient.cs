using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

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
    public async Task<IEnumerable<CustomPaymentMethodSchemaResponse>> GetAllAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest { Method = HttpMethod.Get, Path = "/paymentMethod/schema" }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<CustomPaymentMethodSchemaResponse>>(
                responseBody
            )!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Create custom payment method schema
    /// </summary>
    public async Task<CustomPaymentMethodSchemaResponse> CreateAsync(
        CustomPaymentMethodSchemaRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/paymentMethod/schema",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<CustomPaymentMethodSchemaResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
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
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/paymentMethod/schema/{schemaId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<CustomPaymentMethodSchemaResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get custom payment method schema
    /// </summary>
    public async Task<CustomPaymentMethodSchemaResponse> GetAsync(string schemaId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/paymentMethod/schema/{schemaId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<CustomPaymentMethodSchemaResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Delete custom payment method schema. Schema that have been used in an invoice cannot be deleted.
    /// </summary>
    public async Task DeleteAsync(string schemaId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/paymentMethod/schema/{schemaId}"
            }
        );
    }
}
