using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class PaymentMethodTypesClient
{
    private RawClient _client;

    public PaymentMethodTypesClient(RawClient client)
    {
        _client = client;
    }
}
