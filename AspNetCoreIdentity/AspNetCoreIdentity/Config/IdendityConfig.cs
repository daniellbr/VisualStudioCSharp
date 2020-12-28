using AspNetCoreIdentity.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreIdentity.Config
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddAuthorizationConfig(this IServiceCollection services)
        {
            services.AddAuthorization(option => {

                option.AddPolicy("PodeExcluir", policy => policy.RequireClaim("PodeExcluir"));
                option.AddPolicy("PodeLer", policy => policy.Requirements.Add(new PermissaoNecessaria("PodeLer")));
                option.AddPolicy("PodeGravar", policy => policy.Requirements.Add(new PermissaoNecessaria("PodeGravar")));

            });

            return services;
        }
    }
}
