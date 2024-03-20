using System.Security.Claims;
using dPosit.AspNet.Authentication.Claims;
using Microsoft.AspNetCore.Http;

namespace dPosit.AspNet.Authentication.Extensions;

public static class HttpContextExtensions
{
    public static Guid GetUserId(this HttpContext context)
    {
        var cliams = context.User.Identity as ClaimsIdentity;
        return new Guid(cliams.FindFirst("UserId").Value);
    }

    public static AccessTokenClaims GetAccessTokenClaims(this HttpContext httpContext)
    {
        var cliams = httpContext.User.Claims.ToList();

        return new AccessTokenClaims().PopulateClaims(cliams);
    }
}
