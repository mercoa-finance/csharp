using Mercoa.Client.Core;

#nullable enable

namespace Mercoa.Client;

public partial class TransactionClient
{
    private RawClient _client;

    internal TransactionClient(RawClient client)
    {
        _client = client;
    }
}
