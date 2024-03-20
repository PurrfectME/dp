using System.Security.Claims;
using dPosit.AspNet.Helpers.Extensions;

namespace dPosit.Jwt.Claims;

public abstract class BaseTokenClaims : ITokenClaims<BaseTokenClaims>
{
    public Guid UserId { get; set; }

    public abstract TokenType TokenType { get; }

    public virtual IReadOnlyCollection<Claim> ToClaimsList()
    {
        return new List<Claim>
        {
            new(Constants.ClaimType.USER_ID, UserId.ToString()),
            new(Constants.ClaimType.TOKEN_TYPE, TokenType.ToString())
        };
    }

    public virtual BaseTokenClaims PopulateClaims(ICollection<Claim> claims)
    {
        UserId = new Guid(claims.GetClaimValue(Constants.ClaimType.USER_ID));

        return this;
    }
}
