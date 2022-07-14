using CalculadoraIR.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CalculadoraIR.Presentation
{
    public static class Configure
    {
        public static IServiceCollection ConfigurePresentation(this IServiceCollection services)
        {
            services.AddScoped<ICalculatorScreen, CalculatorScreen>();
            return services;
        }
    }
}
