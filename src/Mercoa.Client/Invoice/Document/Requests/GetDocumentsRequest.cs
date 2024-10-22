using Mercoa.Client;

#nullable enable

namespace Mercoa.Client.Invoice;

public record GetDocumentsRequest
{
    /// <summary>
    /// Filter by document type
    /// </summary>
    public IEnumerable<DocumentType> Type { get; set; } = new List<DocumentType>();
}
