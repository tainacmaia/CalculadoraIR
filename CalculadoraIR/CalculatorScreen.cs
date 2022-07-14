using CalculadoraIR.Presentation.Interfaces;
using CalculadoraIR.Services.Interfaces;

namespace CalculadoraIR.Presentation
{
    public class CalculatorScreen : ICalculatorScreen
    {
        private readonly ITaxCalculator _taxCalculator;

        public CalculatorScreen(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }

        public double StartCalculation()
        {
            double amount;
            double tax;
            Console.WriteLine(@"Bem-vindo à calculadora de Imposto de Renda!
Digite o valor a ser utilizado para o cálculo:");
            while (!double.TryParse(Console.ReadLine(), out amount) || amount < 0)
            {
                Console.WriteLine("Incorreto. Digite novamente:");
            }
            tax = _taxCalculator.TaxCalculation(amount);
            Console.WriteLine($"O valor do imposto a ser pago é: {Math.Round(tax, 2)}");
            return amount;
        }

    }
}
