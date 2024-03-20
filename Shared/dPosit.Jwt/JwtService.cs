using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using dPosit.Jwt.Policy;

namespace dPosit.Jwt;

public class JwtService : IJwtService
{
    private readonly JwtOptions _options;

    public JwtService(JwtOptions options)
    {
        _options = options;
    }

    public string CreateToken(IEnumerable<Claim> claims, TimeSpan expiresIn)
    {
        var signingCredentials = DPositSigningCredentials.Create(_options.Secret);
        var tokenOptions = new JwtSecurityToken(
            issuer: _options.Issuer,
            audience: _options.Audience,
            claims: claims,
            expires: DateTime.UtcNow.Add(expiresIn),
            signingCredentials: signingCredentials
        );

        return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
    }

    public bool ValidateToken(string jwt)
    {
        var jwtOptions = new JwtOptions
        {
            Secret = _options.Secret,
            Issuer = _options.Issuer,
            Audience = _options.Audience
        };

        try
        {
            var tokenValidationParameters = new DPositTokenValidationParameters(jwtOptions);
            new JwtSecurityTokenHandler().ValidateToken(jwt, tokenValidationParameters, out _);
        }
        catch
        {
            return false;
        }

        return true;
    }

    public List<Claim> GetClaims(string jwt) => new JwtSecurityTokenHandler().ReadJwtToken(jwt).Claims.ToList();
}
