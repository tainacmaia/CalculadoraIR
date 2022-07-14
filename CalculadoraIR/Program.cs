using CalculadoraIR.Interfaces;
using CalculadoraIR.Presentation;
using CalculadoraIR.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CalculadoraIR
{
    class Program
    {
        public static void Main()
        {
            IServiceCollection services = new ServiceCollection();
            services.ConfigurePresentation()
                    .ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            var calculatorScreen = serviceProvider.GetService<ICalculatorScreen>();
            calculatorScreen.StartCalculation();
        }
    }
}