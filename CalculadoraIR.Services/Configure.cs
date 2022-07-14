using CalculadoraIR.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CalculadoraIR.Services
{
    public static class Configure
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ITaxCalculator, TaxCalculator>();
            return services;
        }
    }
}
