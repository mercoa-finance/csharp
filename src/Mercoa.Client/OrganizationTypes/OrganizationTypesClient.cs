using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public partial class OrganizationTypesClient
{
    private RawClient _client;

    internal OrganizationTypesClient(RawClient client)
    {
        _client = client;
    }
}
