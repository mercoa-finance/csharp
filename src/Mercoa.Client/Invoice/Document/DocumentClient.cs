using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Invoice;

#nullable enable

namespace Mercoa.Client.Invoice;

public class DocumentClient
{
    private RawClient _client;

    public DocumentClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get attachments (scanned/uploaded PDFs and images) associated with this invoice
    /// </summary>
    public async Task<IEnumerable<DocumentResponse>> GetAllAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/documents" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<DocumentResponse>>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Upload documents (scanned/uploaded PDFs and images) associated with this Invoice
    /// </summary>
    public async void UploadAsync(UploadDocumentRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/document",
                Body = request
            }
        );
    }

    /// <summary>
    /// Delete an attachment (scanned/uploaded PDFs and images) associated with this invoice
    /// </summary>
    public async void DeleteAsync(string documentId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/document/{documentId}"
            }
        );
    }

    /// <summary>
    /// Generate a PDF of the invoice. This PDF is generated from the data in the invoice, not from the uploaded documents.
    /// </summary>
    public async Task<DocumentResponse> GenerateInvoicePdfAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/pdf/generate" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<DocumentResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get a PDF of the check for the invoice. If the invoice does not have check as the disbursement method, an error will be returned. If the disbursement option for the check is set to 'MAIL', a void copy of the check will be returned. If the disbursement option for the check is set to 'PRINT', a printable check will be returned. If the invoice is NOT marked as PAID, the check will be a void copy.
    /// </summary>
    public async Task<DocumentResponse> GenerateCheckPdfAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/check/generate" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<DocumentResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get the email subject and body that was used to create this invoice.
    /// </summary>
    public async Task<EmailLogResponse> GetSourceEmailAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/source-email" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EmailLogResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
