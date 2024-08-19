using System.Net.Http;

namespace Mercoa.Client.Core;

internal static class HttpMethodExtensions
{
    public static readonly HttpMethod Patch = new("PATCH");
}
