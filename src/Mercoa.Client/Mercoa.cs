using Mercoa.Client;
using Mercoa.Client.Entity;
using Mercoa.Client.Invoice;
using Mercoa.Client.Organization;

namespace Mercoa.Client;

public partial class Mercoa
{
    private RawClient _client;

    public Mercoa(string token = null, ClientOptions clientOptions = null)
    {
        _client = new RawClient(
            new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {token}" },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Mercoa.Client" },
                { "X-Fern-SDK-Version", "v0.3.37" },
            },
            clientOptions ?? new ClientOptions()
        );
        Entity = new EntityClient(_client);
        Invoice = new InvoiceClient(_client);
        Organization = new OrganizationClient(_client);
        BankLookup = new BankLookupClient(_client);
        Commons = new CommonsClient(_client);
        CustomPaymentMethodSchema = new CustomPaymentMethodSchemaClient(_client);
        EmailLogTypes = new EmailLogTypesClient(_client);
        EntityTypes = new EntityTypesClient(_client);
        Fees = new FeesClient(_client);
        InvoiceTypes = new InvoiceTypesClient(_client);
        Ocr = new OcrClient(_client);
        OrganizationTypes = new OrganizationTypesClient(_client);
        PaymentMethodTypes = new PaymentMethodTypesClient(_client);
    }

    public EntityClient Entity { get; }

    public InvoiceClient Invoice { get; }

    public OrganizationClient Organization { get; }

    public BankLookupClient BankLookup { get; }

    public CommonsClient Commons { get; }

    public CustomPaymentMethodSchemaClient CustomPaymentMethodSchema { get; }

    public EmailLogTypesClient EmailLogTypes { get; }

    public EntityTypesClient EntityTypes { get; }

    public FeesClient Fees { get; }

    public InvoiceTypesClient InvoiceTypes { get; }

    public OcrClient Ocr { get; }

    public OrganizationTypesClient OrganizationTypes { get; }

    public PaymentMethodTypesClient PaymentMethodTypes { get; }

    private string GetFromEnvironmentOrThrow(string env, string message)
    {
        var value = Environment.GetEnvironmentVariable(env);
        if (value == null)
        {
            throw new Exception(message);
        }
        return value;
    }
}
