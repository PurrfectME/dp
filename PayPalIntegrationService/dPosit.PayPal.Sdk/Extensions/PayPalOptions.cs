namespace dPosit.PayPal.Sdk.Extensions;

public sealed class PayPalOptions
{
    public ApiMode ApiMode { get; set; }

    internal string ApiBaseUri { get; set; }

    public CredentialsOptions Credentials { get; set; }

    public sealed class CredentialsOptions
    {
        public string ClientId { get; set; }
        public string Secret { get; set; }
    }
}

public enum ApiMode
{
    Sandbox,
    Production
}
