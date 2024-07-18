using System.Net.Http;

namespace Mercoa.Client.Core;

public static class HttpMethodExtensions
{
    public static readonly HttpMethod Patch = new("PATCH");
}
