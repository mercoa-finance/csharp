namespace Mercoa.Client.Entity;

public class CompleteMicroDepositsRequest
{
    /// <summary>
    /// The amounts of the micro deposits in cents
    /// </summary>
    public List<int> Amounts { get; init; }
}
