using dPosit.PayPal.Sdk;
using dPosit.PayPal.Sdk.Clients;
using dPosit.PayPal.Sdk.Clients.Authorization;
using dPosit.PayPal.Sdk.Clients.Orders;
using dPosit.PayPal.Sdk.Clients.Payments;
using dPosit.PayPal.Sdk.Clients.TransactionSearch;
using dPosit.PayPal.Sdk.Extensions;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddPayPayHttpClient(
        this IServiceCollection services,
        Action<PayPalOptions> payPalConfiguration = null)
    {
        var payPalOptions = new PayPalOptions
        {
            ApiMode = ApiMode.Sandbox
        };

        payPalConfiguration?.Invoke(payPalOptions);

        payPalOptions.ApiBaseUri = payPalOptions.ApiMode switch
        {
            ApiMode.Sandbox => Constants.Origin.SANDBOX,
            ApiMode.Production => Constants.Origin.PRODUCTION,
            _ => throw new ArgumentOutOfRangeException(),
        };

        services.Configure<PayPalOptions>(options =>
        {
            options.ApiMode = payPalOptions.ApiMode;
            options.Credentials = payPalOptions.Credentials;
            options.ApiBaseUri = payPalOptions.ApiBaseUri;
        });

        services.AddHttpClient<IPayPalAuthorizationClient, PayPalAuthorizationClient>();
        services.AddHttpClient<IPayPalOrdersClient, PayPalOrdersClient>();
        services.AddHttpClient<IPayPalPaymentsClient, PayPalPaymentsClient>();
        services.AddHttpClient<IPayPalTransactionSearchClient, PayPalTransactionSearchClient>();

        return services;
    }
}
