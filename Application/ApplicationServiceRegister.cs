using Application.UseCases;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationServiceRegister
    {
        public static IServiceCollection AddApplicationRegister(this IServiceCollection services)
        {
            services.AddScoped<ISupplierUseCase, SupplierUseCase>();
            return services;
        }
    }
}
