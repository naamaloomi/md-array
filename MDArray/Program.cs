using System;
using System.Collections.Generic;

namespace MDArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Definiera regler som delegater. 
            Datcha.Del regelA = Datcha.RegelA;
            Datcha.Del regelB = Datcha.RegelB;
            Datcha.Del regelC = Datcha.RegelC;

            // Definiera regelverk.
            var rules = new Dictionary<(Motpart, RiskGrupp), Delegate>
            {
                {(Motpart.Brf, RiskGrupp.A), regelA},
                {(Motpart.Brf, RiskGrupp.B), regelA},
                {(Motpart.Brf, RiskGrupp.C), regelB},
                {(Motpart.FastighetsBolag, RiskGrupp.A), regelB},
                {(Motpart.FastighetsBolag, RiskGrupp.B), regelC},
                {(Motpart.FastighetsBolag, RiskGrupp.C), regelC},
                {(Motpart.Ovriga, RiskGrupp.A), regelA},
                {(Motpart.Ovriga, RiskGrupp.B), regelB},
                {(Motpart.Ovriga, RiskGrupp.C), regelC}
            };

            var motpart = Motpart.Brf;
        }
    }
}