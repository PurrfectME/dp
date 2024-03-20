using dPosit.Http.Helpers;

namespace dPosit.PayPal.Sdk.Extensions;

internal static class PayPalExtensions
{
    internal static HttpRequestMessageBuilder AddPayPalBasicAuthentication(
        this HttpRequestMessageBuilder builder,
        PayPalOptions.CredentialsOptions credentialsOptions) =>
        builder.AddBasicAuthentication(credentialsOptions.ClientId, credentialsOptions.Secret);
}
