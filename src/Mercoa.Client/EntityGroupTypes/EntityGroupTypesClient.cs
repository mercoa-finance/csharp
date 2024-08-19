using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public partial class EntityGroupTypesClient
{
    private RawClient _client;

    internal EntityGroupTypesClient(RawClient client)
    {
        _client = client;
    }
}
