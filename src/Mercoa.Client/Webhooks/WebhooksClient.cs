using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public class WebhooksClient
{
    private RawClient _client;

    public WebhooksClient(RawClient client)
    {
        _client = client;
    }
}
