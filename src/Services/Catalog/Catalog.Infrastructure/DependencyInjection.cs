
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddApiServices(
        this IServiceCollection services
    )
    {
        return services;
    }
}