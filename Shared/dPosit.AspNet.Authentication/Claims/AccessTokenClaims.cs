using System.Security.Claims;
using dPosit.AspNet.Helpers.Extensions;
using dPosit.Jwt;
using dPosit.Jwt.Claims;

namespace dPosit.AspNet.Authentication.Claims;

public class AccessTokenClaims : BaseTokenClaims, ITokenClaims<AccessTokenClaims>
{
    public string Email { get; set; }
    public string Username { get; set; }
    public override TokenType TokenType => new AccessTokenType();

    public override IReadOnlyCollection<Claim> ToClaimsList()
    {
        var claimList = base.ToClaimsList().ToList();
        claimList.Add(new Claim(Constants.ClaimType.EMAIL, Email));
        claimList.Add(new Claim(Constants.ClaimType.USERNAME, Username));

        return claimList.AsReadOnly();
    }

    public override AccessTokenClaims PopulateClaims(ICollection<Claim> claims)
    {
        base.PopulateClaims(claims);

        Username = claims.GetClaimValue(Constants.ClaimType.USERNAME);
        Email = claims.GetClaimValue(Constants.ClaimType.EMAIL);

        return this;
    }
}
