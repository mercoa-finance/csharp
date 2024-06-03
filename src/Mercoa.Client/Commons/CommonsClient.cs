using Mercoa.Client;

#nullable enable

namespace Mercoa.Client;

public class CommonsClient
{
    private RawClient _client;

    public CommonsClient(RawClient client)
    {
        _client = client;
    }
}
