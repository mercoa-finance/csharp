using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.InvoiceTemplate;

public record GetDocumentsRequest
{
    /// <summary>
    /// Filter by document type
    /// </summary>
    public IEnumerable<DocumentType> Type { get; set; } = new List<DocumentType>();
}
