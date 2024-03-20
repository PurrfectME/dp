namespace dPosit.PrimeTrust.Sdk.Contracts;
public interface IPrimeTrustClient
{
    Task<TResponse> GetAsync<TRequest, TResponse>(string url, TRequest data = null, CancellationToken cancellationToken = default) where TRequest : class;
    Task<TResponse> GetAsync<TResponse>(string url, CancellationToken cancellationToken = default);
    Task<TResponse> PostAsync<TRequest, TResponse>(TRequest data, string url, CancellationToken cancellationToken = default);
    Task<TResponse> PostAsync<TResponse>(string url, CancellationToken cancellationToken = default);
    Task<TResponse> PatchAsync<TRequest, TResponse>(TRequest data, string url, CancellationToken cancellationToken = default);
}
