using System.Net.Http.Headers;
using System.Text;

namespace dPosit.Http.Extensions;

public static class HttpRequestHeadersExtensions
{
    public static void AddBasicAuthorizationHeader(this HttpRequestHeaders headers, string login, string password)
    {
        string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(login + ":" + password));
        headers.AddAuthorizationHeader($"Basic {credentials}");
    }

    public static void AddBearerAuthorizationHeader(this HttpRequestHeaders headers, string token)
    {
        headers.AddAuthorizationHeader($"Bearer {token}");
    }

    public static void AddAuthorizationHeader(this HttpRequestHeaders headers, string value)
    {
        headers.Add("Authorization", value);
    }
}