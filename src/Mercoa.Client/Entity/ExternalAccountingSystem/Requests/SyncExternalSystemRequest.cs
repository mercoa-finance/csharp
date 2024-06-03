using Mercoa.Client.Entity;

#nullable enable

namespace Mercoa.Client.Entity;

public class SyncExternalSystemRequest
{
    /// <summary>
    /// Sync vendors from external accounting system. Default is to pull vendors from external system.
    /// </summary>
    public SyncType? Vendors { get; init; }

    /// <summary>
    /// Sync bills from external accounting system. Default is to not sync bills.
    /// </summary>
    public SyncType? Bills { get; init; }

    /// <summary>
    /// Sync GL accounts from external accounting system. Default is to pull GL accounts from external system. Pushing GL accounts is not supported.
    /// </summary>
    public SyncType? GlAccounts { get; init; }
}
