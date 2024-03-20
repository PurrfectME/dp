using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using dPosit.Http.Extensions;
using Microsoft.AspNetCore.WebUtilities;

namespace dPosit.Http.Helpers;

public class HttpRequestMessageBuilder
{
    private readonly HttpRequestMessage _message;

    public HttpRequestMessageBuilder()
    {
        _message = new HttpRequestMessage();
    }

    public HttpRequestMessageBuilder UseUrl(
        string url,
        IDictionary<string, string> queryParams = null,
        UriKind uriKind = UriKind.Relative)
    {
        if (queryParams is not null)
        {
            url = QueryHelpers.AddQueryString(url, queryParams);
        }

        _message.RequestUri = new Uri(url, uriKind);

        return this;
    }

    public HttpRequestMessageBuilder UseMethod(HttpMethod method)
    {
        _message.Method = method;
        return this;
    }

    public HttpRequestMessageBuilder AddJsonContent<T>(T body, JsonSerializerOptions options = null)
    {
        return AddContent(JsonContent.Create<T>(body, options: options));
    }

    public HttpRequestMessageBuilder AddContent(HttpContent content)
    {
        _message.Content = content;
        return this;
    }

    public HttpRequestMessageBuilder AddHeaders(IDictionary<string, string> headers)
    {
        if (headers is null)
        {
            return this;
        }

        foreach (var (headerName, headerValue) in headers)
        {
            _message.Headers.Add(headerName, headerValue);
        }

        return this;
    }

    public HttpRequestMessageBuilder AddHeader(string name, string value)
    {
        _message.Headers.Add(name, value);
        return this;
    }

    public HttpRequestMessageBuilder AddBasicAuthentication(string login, string password)
    {
        _message.Headers.AddBasicAuthorizationHeader(login, password);
        return this;
    }

    public HttpRequestMessageBuilder AddBearerAuthentication(string token)
    {
        _message.Headers.AddBearerAuthorizationHeader(token);
        return this;
    }

    public HttpRequestMessageBuilder AddFormUrlEncodedContent(IEnumerable<KeyValuePair<string, string>> values)
    {
        _message.Content = new FormUrlEncodedContent(values);
        return this;
    }

    public HttpRequestMessageBuilder AddAcceptMediaType(string mediaType)
    {
        _message.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse(mediaType));
        return this;
    }

    public HttpRequestMessage Build()
    {
        return _message;
    }
}
