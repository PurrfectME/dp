using dPosit.Jwt;

namespace dPosit.AspNet.Authentication.Claims;

public sealed record AccessTokenType : TokenType
{
    public override string Type => Constants.TokenType.ACCESS_TOKEN_TYPE;
}
