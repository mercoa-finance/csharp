using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public partial class CommonsClient
{
    private RawClient _client;

    internal CommonsClient(RawClient client)
    {
        _client = client;
    }
}
