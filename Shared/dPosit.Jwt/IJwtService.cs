using System.Security.Claims;

namespace dPosit.Jwt;

public interface IJwtService
{
    string CreateToken(IEnumerable<Claim> claims, TimeSpan expiresIn);
    bool ValidateToken(string jwt);
    List<Claim> GetClaims(string jwt);
}
