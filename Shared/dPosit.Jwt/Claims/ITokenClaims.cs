using System.Security.Claims;

namespace dPosit.Jwt.Claims;

public interface ITokenClaims<out T>
{
    TokenType TokenType { get; }
    T PopulateClaims(ICollection<Claim> claims);
    IReadOnlyCollection<Claim> ToClaimsList();
}
