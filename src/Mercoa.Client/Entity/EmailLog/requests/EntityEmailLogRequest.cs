namespace Mercoa.Client.Entity.EmailLog;

public class EntityEmailLogRequest
{
    public DateTime? StartDate { get; init; }

    public DateTime? EndDate { get; init; }

    /// <summary>
    /// Number of logs to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The ID of the log to start after. If not provided, the first page of logs will be returned.
    /// </summary>
    public string? StartingAfter { get; init; }

    /// <summary>
    /// Search for logs by email address or subject
    /// </summary>
    public string? Search { get; init; }
}
