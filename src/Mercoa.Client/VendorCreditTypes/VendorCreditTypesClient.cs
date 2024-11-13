using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public partial class VendorCreditTypesClient
{
    private RawClient _client;

    internal VendorCreditTypesClient(RawClient client)
    {
        _client = client;
    }
}
