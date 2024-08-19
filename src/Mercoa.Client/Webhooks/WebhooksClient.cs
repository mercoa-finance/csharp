using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public partial class WebhooksClient
{
    private RawClient _client;

    internal WebhooksClient(RawClient client)
    {
        _client = client;
    }
}
