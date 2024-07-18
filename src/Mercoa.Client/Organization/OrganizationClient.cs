using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;
using Mercoa.Client.Organization;

#nullable enable

namespace Mercoa.Client.Organization;

public class OrganizationClient
{
    private RawClient _client;

    public OrganizationClient(RawClient client)
    {
        _client = client;
        NotificationConfiguration = new NotificationConfigurationClient(_client);
    }

    public NotificationConfigurationClient NotificationConfiguration { get; }

    /// <summary>
    /// Get current organization information
    /// </summary>
    public async Task<OrganizationResponse> GetAsync(GetOrganizationRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.PaymentMethods != null)
        {
            _query["paymentMethods"] = request.PaymentMethods.ToString();
        }
        if (request.EmailProvider != null)
        {
            _query["emailProvider"] = request.EmailProvider.ToString();
        }
        if (request.ExternalAccountingSystemProvider != null)
        {
            _query["externalAccountingSystemProvider"] =
                request.ExternalAccountingSystemProvider.ToString();
        }
        if (request.ColorScheme != null)
        {
            _query["colorScheme"] = request.ColorScheme.ToString();
        }
        if (request.PayeeOnboardingOptions != null)
        {
            _query["payeeOnboardingOptions"] = request.PayeeOnboardingOptions.ToString();
        }
        if (request.PayorOnboardingOptions != null)
        {
            _query["payorOnboardingOptions"] = request.PayorOnboardingOptions.ToString();
        }
        if (request.MetadataSchema != null)
        {
            _query["metadataSchema"] = request.MetadataSchema.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "organization",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<OrganizationResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update current organization
    /// </summary>
    public async Task<OrganizationResponse> UpdateAsync(OrganizationRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "organization",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<OrganizationResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get log of all emails sent to this organization. Content format subject to change.
    /// </summary>
    public async Task<EmailLogResponse> EmailLogAsync(GetEmailLogRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.StartDate != null)
        {
            _query["startDate"] = request.StartDate.Value.ToString("o0");
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate.Value.ToString("o0");
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.StartingAfter != null)
        {
            _query["startingAfter"] = request.StartingAfter;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "organization/emailLog",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<EmailLogResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
