using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace dPosit.Jwt.Policy;

public class DPositSigningCredentials : SigningCredentials
{
    private DPositSigningCredentials(SecurityKey key, string algorithm) : base(key, algorithm)
    {
    }

    public static DPositSigningCredentials Create(string secret)
    {
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
        return new DPositSigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
    }
}
