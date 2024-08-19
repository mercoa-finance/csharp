using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client.Organization;

public partial class OrganizationClient
{
    private RawClient _client;

    internal OrganizationClient(RawClient client)
    {
        _client = client;
        NotificationConfiguration = new NotificationConfigurationClient(_client);
    }

    public NotificationConfigurationClient NotificationConfiguration { get; }

    /// <summary>
    /// Get current organization information
    /// </summary>
    public async Task<OrganizationResponse> GetAsync(
        GetOrganizationRequest request,
        RequestOptions? options = null
    )
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
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "organization",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<OrganizationResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MercoaException("Failed to deserialize response", e);
            }
        }

        throw new MercoaApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Update current organization
    /// </summary>
    public async Task<OrganizationResponse> UpdateAsync(
        OrganizationRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "organization",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<OrganizationResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MercoaException("Failed to deserialize response", e);
            }
        }

        throw new MercoaApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Get log of all emails sent to this organization. Content format subject to change.
    /// </summary>
    public async Task<EmailLogResponse> EmailLogAsync(
        GetEmailLogRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.StartDate != null)
        {
            _query["startDate"] = request.StartDate.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.EndDate != null)
        {
            _query["endDate"] = request.EndDate.Value.ToString(Constants.DateTimeFormat);
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
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "organization/emailLog",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<EmailLogResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MercoaException("Failed to deserialize response", e);
            }
        }

        throw new MercoaApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
