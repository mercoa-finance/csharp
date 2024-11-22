namespace Mercoa.Client;

public record FindTransactionsRequest
{
    /// <summary>
    /// Filter transactions by the ID or foreign ID of the entity that is the payer or the vendor of the invoice that created the transaction.
    /// </summary>
    public IEnumerable<string> EntityId { get; set; } = new List<string>();

    /// <summary>
    /// CREATED_AT Start date filter.
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// CREATED_AT End date filter.
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Number of transactions to return. Limit can range between 1 and 100, and the default is 10.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// The ID of the transactions to start after. If not provided, the first page of transactions will be returned.
    /// </summary>
    public string? StartingAfter { get; set; }

    /// <summary>
    /// Find transactions by vendor name, invoice number, or amount. Partial matches are supported.
    /// </summary>
    public string? Search { get; set; }

    /// <summary>
    /// Filter transactions by invoice metadata. Each filter will be applied as an AND condition. Duplicate keys will be ignored.
    /// </summary>
    public IEnumerable<MetadataFilter> Metadata { get; set; } = new List<MetadataFilter>();

    /// <summary>
    /// Filter transactions by invoice line item metadata. Each filter will be applied as an AND condition. Duplicate keys will be ignored.
    /// </summary>
    public IEnumerable<MetadataFilter> LineItemMetadata { get; set; } = new List<MetadataFilter>();

    /// <summary>
    /// Filter transactions by invoice line item GL account ID. Each filter will be applied as an OR condition. Duplicate keys will be ignored.
    /// </summary>
    public IEnumerable<string> LineItemGlAccountId { get; set; } = new List<string>();

    /// <summary>
    /// Filter transactions by payer ID or payer foreign ID.
    /// </summary>
    public IEnumerable<string> PayerId { get; set; } = new List<string>();

    /// <summary>
    /// Filter transactions by vendor ID or vendor foreign ID.
    /// </summary>
    public IEnumerable<string> VendorId { get; set; } = new List<string>();

    /// <summary>
    /// Filter transactions by the ID or foreign ID of the user that created the invoice that created the transaction.
    /// </summary>
    public IEnumerable<string> CreatorUserId { get; set; } = new List<string>();

    /// <summary>
    /// Filter transactions by invoice ID.
    /// </summary>
    public IEnumerable<string> InvoiceId { get; set; } = new List<string>();

    /// <summary>
    /// Filter transactions by transaction ID.
    /// </summary>
    public IEnumerable<string> TransactionId { get; set; } = new List<string>();

    /// <summary>
    /// Transaction status to filter on
    /// </summary>
    public IEnumerable<TransactionStatus> Status { get; set; } = new List<TransactionStatus>();

    /// <summary>
    /// Filter transactions by transaction type
    /// </summary>
    public IEnumerable<TransactionType> TransactionType { get; set; } = new List<TransactionType>();
}
