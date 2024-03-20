using System.Security.Claims;

namespace dPosit.AspNet.Helpers.Extensions;

public static class ClaimListExtensions
{
    public static string GetClaimValue(this ICollection<Claim> claims, string claimType)
    {
        return claims.FirstOrDefault(c => c.Type == claimType)?.Value;
    }
}
