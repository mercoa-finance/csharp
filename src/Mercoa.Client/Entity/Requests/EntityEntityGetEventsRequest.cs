namespace Mercoa.Client.Entity;

public record EntityEntityGetEventsRequest
{
    /// <summary>
    /// Start date filter. If not provided, events from the start of time will be returned.
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// End date filter. If not provided, events to the end of time will be returned.
    /// </summary>
    public DateTime? EndDate { get; set; }
}
