using CalculadoraIR.Domain;
using CalculadoraIR.Services.Interfaces;

namespace CalculadoraIR.Services
{
    public class TaxCalculator : ITaxCalculator
    {

        public double TaxCalculation(double value)
        {
            var tier = TierData.TierList.FirstOrDefault(t => t.Mininum <= value && t.Maximum >= value);
            double tax = value * tier.Aliquot - tier.Deduction;
            return tax;
        }
    }
}