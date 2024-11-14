using System;
using Mercoa.Client.Core;
using Mercoa.Client.Entity;
using Mercoa.Client.EntityGroup;
using Mercoa.Client.Invoice;
using Mercoa.Client.InvoiceTemplate;
using Mercoa.Client.Organization;

#nullable enable

namespace Mercoa.Client;

public partial class Mercoa
{
    private RawClient _client;

    public Mercoa(string? token = null, ClientOptions? clientOptions = null)
    {
        _client = new RawClient(
            new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {token}" },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Mercoa.Client" },
                { "X-Fern-SDK-Version", "0.5.13-rc2" },
            },
            new Dictionary<string, Func<string>>() { },
            clientOptions ?? new ClientOptions()
        );
        EntityGroup = new EntityGroupClient(_client);
        Entity = new EntityClient(_client);
        InvoiceTemplate = new InvoiceTemplateClient(_client);
        Invoice = new InvoiceClient(_client);
        Organization = new OrganizationClient(_client);
        BankLookup = new BankLookupClient(_client);
        Calculate = new CalculateClient(_client);
        Commons = new CommonsClient(_client);
        CustomPaymentMethodSchema = new CustomPaymentMethodSchemaClient(_client);
        EmailLogTypes = new EmailLogTypesClient(_client);
        EntityGroupTypes = new EntityGroupTypesClient(_client);
        EntityTypes = new EntityTypesClient(_client);
        InvoiceTypes = new InvoiceTypesClient(_client);
        Ocr = new OcrClient(_client);
        OrganizationTypes = new OrganizationTypesClient(_client);
        PaymentMethodTypes = new PaymentMethodTypesClient(_client);
        PaymentMethods = new PaymentMethodsClient(_client);
        VendorCreditTypes = new VendorCreditTypesClient(_client);
        Webhooks = new WebhooksClient(_client);
    }

    public EntityGroupClient EntityGroup { get; init; }

    public EntityClient Entity { get; init; }

    public InvoiceTemplateClient InvoiceTemplate { get; init; }

    public InvoiceClient Invoice { get; init; }

    public OrganizationClient Organization { get; init; }

    public BankLookupClient BankLookup { get; init; }

    public CalculateClient Calculate { get; init; }

    public CommonsClient Commons { get; init; }

    public CustomPaymentMethodSchemaClient CustomPaymentMethodSchema { get; init; }

    public EmailLogTypesClient EmailLogTypes { get; init; }

    public EntityGroupTypesClient EntityGroupTypes { get; init; }

    public EntityTypesClient EntityTypes { get; init; }

    public InvoiceTypesClient InvoiceTypes { get; init; }

    public OcrClient Ocr { get; init; }

    public OrganizationTypesClient OrganizationTypes { get; init; }

    public PaymentMethodTypesClient PaymentMethodTypes { get; init; }

    public PaymentMethodsClient PaymentMethods { get; init; }

    public VendorCreditTypesClient VendorCreditTypes { get; init; }

    public WebhooksClient Webhooks { get; init; }
}
