using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public partial class PaymentMethodTypesClient
{
    private RawClient _client;

    internal PaymentMethodTypesClient(RawClient client)
    {
        _client = client;
    }
}
