
namespace CalculadoraIR.Domain
{
    public static class TierData
    {
        public static readonly List<Tier> TierList = new()
        {
            new Tier { Mininum = 0, Maximum = 22847.76, Aliquot = 0, Deduction = 0 },
            new Tier { Mininum = 22847.77, Maximum = 33919.8, Aliquot = 0.075, Deduction = 1713.58 },
            new Tier { Mininum = 33919.81, Maximum = 45012.60, Aliquot = 0.15, Deduction = 4257.57 },
            new Tier { Mininum = 45012.61, Maximum = 55976.16, Aliquot = 0.225, Deduction = 7633.51 },
            new Tier { Mininum = 55976.17, Maximum = double.MaxValue, Aliquot = 0.275, Deduction = 10432.32 }
        };
    }
}
