using dPosit.Http.Helpers;
using dPosit.PrimeTrust.Sdk.Contracts;
using dPosit.PrimeTrust.Sdk.RequestModels;
using System.Text.Json;

namespace dPosit.PrimeTrust.Sdk.HttpClients;

public partial class PrimeTrustClient : IPrimeTrustClient
{
    private readonly HttpClient _httpClient;

    //todo: retrieve from settings
    private static readonly Uri _baseUrl = new("https://sandbox.primetrust.com");

    public PrimeTrustClient()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = _baseUrl
        };
    }

    public Task<TResponse> GetAsync<TRequest, TResponse>(string url, TRequest data = null, CancellationToken cancellationToken = default) where TRequest : class =>
        ProccessRequest<TRequest, TResponse>(data, url, HttpMethod.Get, cancellationToken: cancellationToken);

    public Task<TResponse> GetAsync<TResponse>(string url, CancellationToken cancellationToken = default) =>
        ProccessRequest<TResponse>(url, HttpMethod.Get, cancellationToken);

    public Task<TResponse> PostAsync<TRequest, TResponse>(TRequest data, string url, CancellationToken cancellationToken = default) =>
        ProccessRequest<TRequest, TResponse>(data, url, HttpMethod.Post, cancellationToken: cancellationToken);

    public Task<TResponse> PostAsync<TResponse>(string url, CancellationToken cancellationToken = default) =>
        ProccessRequest<TResponse>(url, HttpMethod.Post, cancellationToken);

    public Task<TResponse> PatchAsync<TRequest, TResponse>(TRequest data, string url, CancellationToken cancellationToken = default) =>
        ProccessRequest<TRequest, TResponse>(data, url, HttpMethod.Patch, cancellationToken: cancellationToken);

    private async Task<TResponse> ProccessRequest<TResponse>(string url, HttpMethod method, CancellationToken cancellationToken = default)
    {

        var builder = new HttpRequestMessageBuilder()
            .UseMethod(method)
            .UseUrl(url)
            .AddBearerAuthentication("GET_FROM_STORE");

        return await Execute<TResponse>(builder.Build(), cancellationToken);
    }

    private async Task<TResponse> ProccessRequest<TRequest, TResponse>(TRequest data, string url, HttpMethod method, bool isBasicAuth = false, CancellationToken cancellationToken = default)
    {
        var builder = new HttpRequestMessageBuilder()
            .UseMethod(method)
            .UseUrl(url);

        if (isBasicAuth)
        {
            var login = data as UserLoginDto;
            builder = builder.AddBasicAuthentication(login.UserName, login.Password);
        }
        else
        {
            builder = builder.AddBearerAuthentication("GET_FROM_STORE");

            if (data is not null)
            {
                builder = builder.AddJsonContent(data);
            }
        }

        return await Execute<TResponse>(builder.Build(), cancellationToken);
    }

    private async Task<TResponse> Execute<TResponse>(HttpRequestMessage message, CancellationToken cancellationToken = default)
    {
        AddHeaders(message);

        var response = await _httpClient.SendAsync(message, cancellationToken);

        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<TResponse>(responseBody)!;
    }

    private void AddHeaders(HttpRequestMessage message)
    {
       message.Headers.Add("X-Idempotent-ID-V2", Guid.NewGuid().ToString());
       message.Headers.Add("User-Agent", "dPosit/V0.1");
       message.Headers.Add("Accept-Encoding", "gzip, deflate, br");
       message.Headers.Add("Connection", "keep-alive");
    }
}
