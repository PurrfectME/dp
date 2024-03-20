using dPosit.Jwt;

namespace dPosit.AspNet.Authentication.Claims;

public sealed record RefreshTokenType : TokenType
{
    public override string Type => Constants.TokenType.REFRESH_TOKEN_TYPE;
}
