namespace dPosit.Jwt.Policy;

public class JwtOptions
{
    public string Secret { get; init; }

    public string Issuer { get; init; }

    public string Audience { get; init; }
}
