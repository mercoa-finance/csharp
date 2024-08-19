namespace Mercoa.Client.Entity;

public record SyncExternalSystemRequest
{
    /// <summary>
    /// Sync vendors from external accounting system. Default is to pull vendors from external system.
    /// </summary>
    public SyncType? Vendors { get; set; }

    /// <summary>
    /// Sync bills from external accounting system. Default is to not sync bills. Invoices that already exist in both systems will not be updated, only new invoices not present in the other system will be created.
    /// </summary>
    public SyncType? Bills { get; set; }

    /// <summary>
    /// Sync GL accounts from external accounting system. Default is to pull GL accounts from external system. Pushing GL accounts is not supported.
    /// </summary>
    public SyncType? GlAccounts { get; set; }
}
