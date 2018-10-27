using System.Collections.Generic;

namespace MDArray
{
    internal class Regelverk
    {
        // Definiera regelverk.
        private static readonly Dictionary<(Motpart, RiskGrupp, Bransch), PropaKrav> Rules =
            new Dictionary<(Motpart, RiskGrupp, Bransch), PropaKrav>
            {
                {(Motpart.Brf, RiskGrupp.A, Bransch.A), PropaKrav.ObligatoriskPerGrupp},
                {(Motpart.Brf, RiskGrupp.A, Bransch.B), PropaKrav.ObligatoriskPerGrupp},
                {(Motpart.Brf, RiskGrupp.A, Bransch.C), PropaKrav.ObligatoriskPerGrupp},
                {(Motpart.Brf, RiskGrupp.B, Bransch.A), PropaKrav.ObligatoriskPerMotpart},
                {(Motpart.Brf, RiskGrupp.B, Bransch.B), PropaKrav.ObligatoriskPerMotpart},
                {(Motpart.Brf, RiskGrupp.B, Bransch.C), PropaKrav.ObligatoriskPerMotpart},
                {(Motpart.Brf, RiskGrupp.C, Bransch.A), PropaKrav.Valfri},
                {(Motpart.Brf, RiskGrupp.C, Bransch.B), PropaKrav.Valfri},
                {(Motpart.Brf, RiskGrupp.C, Bransch.C), PropaKrav.Valfri},
                {(Motpart.FastighetsBolag, RiskGrupp.A, Bransch.A), PropaKrav.ObligatoriskPerGrupp},
                {(Motpart.FastighetsBolag, RiskGrupp.A, Bransch.B), PropaKrav.ObligatoriskPerGrupp},
                {(Motpart.FastighetsBolag, RiskGrupp.A, Bransch.C), PropaKrav.ObligatoriskPerGrupp},
                {(Motpart.FastighetsBolag, RiskGrupp.B, Bransch.A), PropaKrav.Valfri},
                {(Motpart.FastighetsBolag, RiskGrupp.B, Bransch.B), PropaKrav.Valfri},
                {(Motpart.FastighetsBolag, RiskGrupp.B, Bransch.C), PropaKrav.Valfri},
                {(Motpart.FastighetsBolag, RiskGrupp.C, Bransch.A), PropaKrav.Valfri},
                {(Motpart.FastighetsBolag, RiskGrupp.C, Bransch.B), PropaKrav.Valfri},
                {(Motpart.FastighetsBolag, RiskGrupp.C, Bransch.C), PropaKrav.Valfri},
                {(Motpart.Ovriga, RiskGrupp.A, Bransch.A), PropaKrav.ObligatoriskPerMotpart},
                {(Motpart.Ovriga, RiskGrupp.A, Bransch.B), PropaKrav.ObligatoriskPerMotpart},
                {(Motpart.Ovriga, RiskGrupp.A, Bransch.C), PropaKrav.ObligatoriskPerMotpart},
                {(Motpart.Ovriga, RiskGrupp.B, Bransch.A), PropaKrav.ObligatoriskPerMotpart},
                {(Motpart.Ovriga, RiskGrupp.B, Bransch.B), PropaKrav.ObligatoriskPerMotpart},
                {(Motpart.Ovriga, RiskGrupp.B, Bransch.C), PropaKrav.ObligatoriskPerMotpart},
                {(Motpart.Ovriga, RiskGrupp.C, Bransch.A), PropaKrav.ObligatoriskPerGrupp},
                {(Motpart.Ovriga, RiskGrupp.C, Bransch.B), PropaKrav.ObligatoriskPerGrupp},
                {(Motpart.Ovriga, RiskGrupp.C, Bransch.C), PropaKrav.ObligatoriskPerGrupp}
            };

        public static PropaKrav GetPropaKrav(Motpart motpart, RiskGrupp riskGrupp, Bransch bransch)
        {
            return Rules[(motpart, riskGrupp, bransch)];
        }
    }
}