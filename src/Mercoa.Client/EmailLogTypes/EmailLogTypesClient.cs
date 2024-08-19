using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public partial class EmailLogTypesClient
{
    private RawClient _client;

    internal EmailLogTypesClient(RawClient client)
    {
        _client = client;
    }
}
