using System.Security.Claims;
using dPosit.Jwt;
using dPosit.Jwt.Claims;

namespace dPosit.AspNet.Authentication.Claims;

public class RefreshTokenClaims : BaseTokenClaims, ITokenClaims<RefreshTokenClaims>
{
    public override TokenType TokenType => new RefreshTokenType();
    public override RefreshTokenClaims PopulateClaims(ICollection<Claim> claims)
    {
        base.PopulateClaims(claims);

        return this;
    }
}
