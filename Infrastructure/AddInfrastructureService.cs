using Application.Repositories;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class AddInfrastructureService
    {
        public static IServiceCollection AddInfrastructureRegister(this IServiceCollection services)
        {
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            return services;
        }
    }
}
