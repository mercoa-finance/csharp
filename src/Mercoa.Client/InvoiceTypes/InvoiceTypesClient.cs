using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public partial class InvoiceTypesClient
{
    private RawClient _client;

    internal InvoiceTypesClient(RawClient client)
    {
        _client = client;
    }
}
