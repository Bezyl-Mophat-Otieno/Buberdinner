using Microsoft.Extensions.DependencyInjection; // Add this using directive

namespace Buberdinner.infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayerDependencies(this IServiceCollection services)
        {
            // Register Services for DI
            return services;
        }
    }
}