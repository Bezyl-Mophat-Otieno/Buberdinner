using Buberdinner.application.services.authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Buberdinner.application;

public static class DependencyInjection {
    public static IServiceCollection AddApplicationLayerDependencies (this  IServiceCollection services ){
        // Register Services for DI
         services.AddScoped<IAuthenticationService , AuthenticationService>();
         return services;
    }
}