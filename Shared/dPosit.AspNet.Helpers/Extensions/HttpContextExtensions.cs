using Microsoft.AspNetCore.Http;

namespace dPosit.AspNet.Helpers.Extensions;

public static class HttpContextExtensions
{
    public static string GetJwtBearerToken(this HttpContext httpContext)
    {
        var authHeader = httpContext.Request.Headers["Authorization"];
        if (authHeader.Count == 0)
        {
            return null;
        }

        var authHeaderVal = authHeader[0];
        if (authHeaderVal.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
        {
            return authHeaderVal.Substring("Bearer ".Length).Trim();
        }

        return null;
    }
}
