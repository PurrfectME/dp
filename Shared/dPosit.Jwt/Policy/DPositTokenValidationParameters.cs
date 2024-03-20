using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace dPosit.Jwt.Policy;

public class DPositTokenValidationParameters : TokenValidationParameters
{
    public DPositTokenValidationParameters(JwtOptions options)
    {
        ValidateIssuer = true;
        ValidateAudience = true;
        ValidateLifetime = true;
        ValidateIssuerSigningKey = true;
        ValidIssuer = options.Issuer;
        ValidAudience = options.Audience;
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(options.Secret));
    }
}
