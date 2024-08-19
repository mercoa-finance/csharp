using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public partial class EntityTypesClient
{
    private RawClient _client;

    internal EntityTypesClient(RawClient client)
    {
        _client = client;
    }
}
