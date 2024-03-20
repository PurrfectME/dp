namespace dPosit.AspNet.Authentication.Configuration;

public sealed class ClientOptions
{
    public const string CLIENT = "Client";

    public string ClientUrl { get; set; }

    public string JwtSecret { get; set; }

    public string JwtIssuer { get; set; }

    public string JwtAudience { get; set; }
}
