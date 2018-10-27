using System;

namespace MDArray
{
    internal class Program
    {
        private static void Main()
        {
            var motpart = Motpart.Brf;
            var riskGrupp = RiskGrupp.B;
            var bransch = Bransch.C;

            var krav = Regelverk.GetPropaKrav(motpart, riskGrupp, bransch);
            Console.WriteLine(krav);
        }
    }
}