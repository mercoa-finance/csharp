namespace Mercoa.Client.Organization;

public record GetEmailLogRequest
{
    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Number of logs to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// The ID of the log to start after. If not provided, the first page of logs will be returned.
    /// </summary>
    public string? StartingAfter { get; set; }
}
