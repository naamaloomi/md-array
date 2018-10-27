namespace MDArray
{
    internal class Datcha
    {
        public delegate bool Del(Motpart motpart, RiskGrupp riskGrupp);

        public static bool RegelA(Motpart motpart, RiskGrupp riskGrupp)
        {
            // Kontrollera motpart
            var rattMotpart = motpart.Equals(Motpart.FastighetsBolag) ||
                              motpart.Equals(Motpart.Ovriga);

            // Kontrollera riskgrupp
            var rattRiskGrupp = riskGrupp.Equals(RiskGrupp.A);

            return rattMotpart && rattRiskGrupp;
        }

        public static bool RegelB(Motpart motpart, RiskGrupp riskGrupp)
        {
            // Kontrollera motpart
            var rattMotpart = motpart.Equals(Motpart.Brf);

            // Kontrollera riskgrupp
            var rattRiskGrupp = riskGrupp.Equals(RiskGrupp.B);

            return rattMotpart && rattRiskGrupp;
        }
        public static bool RegelC(Motpart motpart, RiskGrupp riskGrupp)
        {
            // Kontrollera motpart
            var rattMotpart = motpart.Equals(Motpart.Brf) ||
                motpart.Equals(Motpart.FastighetsBolag);

            // Kontrollera riskgrupp
            var rattRiskGrupp = riskGrupp.Equals(RiskGrupp.B);

            return rattMotpart && rattRiskGrupp;
        }
    }
}