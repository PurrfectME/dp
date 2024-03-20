using dPosit.Jwt.Policy;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;

namespace dPosit.AspNet.Authentication.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDPositBearerAuthentication(this IServiceCollection serviceCollection, JwtOptions jwtOptions)
    {
        serviceCollection
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new DPositTokenValidationParameters(jwtOptions);
            });

        return serviceCollection;
    }
}
