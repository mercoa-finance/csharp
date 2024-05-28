using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Entity;
using Mercoa.Client.Entity.EmailLog;
using Mercoa.Client.Entity.User;

namespace Mercoa.Client.Entity;

public class EntityClient
{
    private RawClient _client;

    public EntityClient(RawClient client)
    {
        _client = client;
        EmailLog = new EmailLogClient(_client);
        User = new UserClient(_client);
        ApprovalPolicy = new ApprovalPolicyClient(_client);
        Counterparty = new CounterpartyClient(_client);
        ExternalAccountingSystem = new ExternalAccountingSystemClient(_client);
        Invoice = new InvoiceClient(_client);
        Metadata = new MetadataClient(_client);
        NotificationPolicy = new NotificationPolicyClient(_client);
        PaymentMethod = new PaymentMethodClient(_client);
        Representative = new RepresentativeClient(_client);
    }

    public EmailLogClient EmailLog { get; }

    public UserClient User { get; }

    public ApprovalPolicyClient ApprovalPolicy { get; }

    public CounterpartyClient Counterparty { get; }

    public ExternalAccountingSystemClient ExternalAccountingSystem { get; }

    public InvoiceClient Invoice { get; }

    public MetadataClient Metadata { get; }

    public NotificationPolicyClient NotificationPolicy { get; }

    public PaymentMethodClient PaymentMethod { get; }

    public RepresentativeClient Representative { get; }

    /// <summary>
    /// Search all entities with the given filters. If no filters are provided, all entities will be returned.
    /// </summary>
    public async Task<FindEntityResponse> FindAsync(FindEntities request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.PaymentMethods != null)
        {
            _query["paymentMethods"] = request.PaymentMethods;
        }
        if (request.IsCustomer != null)
        {
            _query["isCustomer"] = request.IsCustomer;
        }
        if (request.ForeignId != null)
        {
            _query["foreignId"] = request.ForeignId;
        }
        if (request.Status != null)
        {
            _query["status"] = request.Status;
        }
        if (request.IsPayee != null)
        {
            _query["isPayee"] = request.IsPayee;
        }
        if (request.IsPayor != null)
        {
            _query["isPayor"] = request.IsPayor;
        }
        if (request.Name != null)
        {
            _query["name"] = request.Name;
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
                Path = "/entity",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<FindEntityResponse>(responseBody);
        }
        throw new Exception();
    }

    public async Task<EntityResponse> CreateAsync(EntityRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/entity",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EntityResponse>(responseBody);
        }
        throw new Exception();
    }

    public async Task<EntityResponse> GetAsync(string entityId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/entity/{entityId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EntityResponse>(responseBody);
        }
        throw new Exception();
    }

    public async Task<EntityResponse> UpdateAsync(string entityId, EntityUpdateRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EntityResponse>(responseBody);
        }
        throw new Exception();
    }

    public async void DeleteAsync(string entityId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/entity/{entityId}" }
        );
    }

    /// <summary>
    /// This endpoint is used to indicate acceptance of Mercoa's terms of service for an entity. Send a request to this endpoint only after the entity has accepted the Mercoa ToS. Entities must accept Mercoa ToS before they can be send or pay invoices using Mercoa's payment rails.
    /// </summary>
    public async void AcceptTermsOfServiceAsync(string entityId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/accept-tos"
            }
        );
    }

    /// <summary>
    /// This endpoint is used to initiate KYB for an entity.
    /// Send a request to this endpoint only after the entity has accepted the Mercoa ToS,
    /// all representatives have been added, and all required fields have been filled out.
    /// </summary>
    public async void InitiateKybAsync(string entityId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/request-kyb"
            }
        );
    }

    /// <summary>
    /// Generate a JWT token for an entity with the given options. This token can be used to authenticate the entity in the Mercoa API and iFrame.
    ///
    /// <Warning>We recommend using [this endpoint](/api-reference/entity/user/get-token). This will enable features such as approvals and comments.</Warning>
    /// </summary>
    public async Task<string> GetTokenAsync(string entityId, TokenGenerationOptions request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/token",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<string>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Get a Plaid link token for an entity. This token can be used to add or update a bank account to the entity using Plaid Link.
    /// </summary>
    public async Task<string> PlaidLinkTokenAsync(string entityId, PlaidLinkTokenRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.PaymentMethodId != null)
        {
            _query["paymentMethodId"] = request.PaymentMethodId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/plaidLinkToken",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<string>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Generate an onboarding link for the entity.
    /// </summary>
    public async Task<string> GetOnboardingLinkAsync(
        string entityId,
        GenerateOnboardingLink request
    )
    {
        var _query = new Dictionary<string, object>() { { "type", request.Type.ToString() }, };
        if (request.ExpiresIn != null)
        {
            _query["expiresIn"] = request.ExpiresIn;
        }
        if (request.ConnectedEntityId != null)
        {
            _query["connectedEntityId"] = request.ConnectedEntityId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/entity/{entityId}/onboarding",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<string>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Send an email with a onboarding link to the entity. The email will be sent to the email address associated with the entity.
    /// </summary>
    public async void SendOnboardingLinkAsync(string entityId, SendOnboardingLink request)
    {
        var _query = new Dictionary<string, object>() { { "type", request.Type.ToString() }, };
        if (request.ExpiresIn != null)
        {
            _query["expiresIn"] = request.ExpiresIn;
        }
        if (request.ConnectedEntityId != null)
        {
            _query["connectedEntityId"] = request.ConnectedEntityId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/entity/{entityId}/onboarding",
                Query = _query
            }
        );
    }
}
