using System.Net.Http;
using System.Text.Json;
using Mercoa.Client;
using Mercoa.Client.Core;
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
    public async Task<IEnumerable<DocumentResponse>> GetAllAsync(string invoiceId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/invoice/{invoiceId}/documents"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<DocumentResponse>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Upload documents (scanned/uploaded PDFs and images) associated with this Invoice
    /// </summary>
    public async Task UploadAsync(string invoiceId, UploadDocumentRequest request)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/invoice/{invoiceId}/document",
                Body = request
            }
        );
    }

    /// <summary>
    /// Delete an attachment (scanned/uploaded PDFs and images) associated with this invoice
    /// </summary>
    public async Task DeleteAsync(string invoiceId, string documentId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/invoice/{invoiceId}/document/{documentId}"
            }
        );
    }

    /// <summary>
    /// Generate a PDF of the invoice. This PDF is generated from the data in the invoice, not from the uploaded documents.
    /// </summary>
    public async Task<DocumentResponse> GenerateInvoicePdfAsync(string invoiceId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/invoice/{invoiceId}/pdf/generate"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<DocumentResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get a PDF of the check for the invoice. If the invoice does not have check as the disbursement method, an error will be returned. If the disbursement option for the check is set to 'MAIL', a void copy of the check will be returned. If the disbursement option for the check is set to 'PRINT', a printable check will be returned. If the invoice is NOT marked as PAID, the check will be a void copy.
    /// </summary>
    public async Task<DocumentResponse> GenerateCheckPdfAsync(string invoiceId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/invoice/{invoiceId}/check/generate"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<DocumentResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get the email subject and body that was used to create this invoice.
    /// </summary>
    public async Task<EmailLogResponse> GetSourceEmailAsync(string invoiceId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/invoice/{invoiceId}/source-email"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<EmailLogResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
