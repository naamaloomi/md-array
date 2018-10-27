using System;
using System.Collections.Generic;

namespace MDArray
{
    internal class Regelverk
    {
        // Definiera regler som delegater. 
        private static readonly Datcha.Del RegelA = Datcha.RegelA;

        private static readonly Datcha.Del RegelB = Datcha.RegelB;
        private static readonly Datcha.Del RegelC = Datcha.RegelC;

        // Definiera regelverk.
        private static readonly Dictionary<(Motpart, RiskGrupp), Delegate> Rules =
            new Dictionary<(Motpart, RiskGrupp), Delegate>
            {
                {(Motpart.Brf, RiskGrupp.A), RegelA},
                {(Motpart.Brf, RiskGrupp.B), RegelA},
                {(Motpart.Brf, RiskGrupp.C), RegelB},
                {(Motpart.FastighetsBolag, RiskGrupp.A), RegelB},
                {(Motpart.FastighetsBolag, RiskGrupp.B), RegelC},
                {(Motpart.FastighetsBolag, RiskGrupp.C), RegelC},
                {(Motpart.Ovriga, RiskGrupp.A), RegelA},
                {(Motpart.Ovriga, RiskGrupp.B), RegelB},
                {(Motpart.Ovriga, RiskGrupp.C), RegelC}
            };

        public static Delegate GetRegel(Motpart motpart, RiskGrupp riskGrupp)
        {
            return Rules[(motpart, riskGrupp)];
        }
    }
}