using System.Text.Json;
using Mercoa.Client;
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
            _query["paymentMethods"] = request.PaymentMethods;
        }
        if (request.EmailProvider != null)
        {
            _query["emailProvider"] = request.EmailProvider;
        }
        if (request.ExternalAccountingSystemProvider != null)
        {
            _query["externalAccountingSystemProvider"] = request.ExternalAccountingSystemProvider;
        }
        if (request.ColorScheme != null)
        {
            _query["colorScheme"] = request.ColorScheme;
        }
        if (request.PayeeOnboardingOptions != null)
        {
            _query["payeeOnboardingOptions"] = request.PayeeOnboardingOptions;
        }
        if (request.PayorOnboardingOptions != null)
        {
            _query["payorOnboardingOptions"] = request.PayorOnboardingOptions;
        }
        if (request.MetadataSchema != null)
        {
            _query["metadataSchema"] = request.MetadataSchema;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/organization",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<OrganizationResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update current organization
    /// </summary>
    public async Task<OrganizationResponse> UpdateAsync(OrganizationRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/organization",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<OrganizationResponse>(responseBody);
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
            _query["startDate"] = request.StartDate;
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit;
        }
        if (request.StartingAfter != null)
        {
            _query["startingAfter"] = request.StartingAfter;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/organization/emailLog",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EmailLogResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
