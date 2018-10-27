namespace MDArray
{
    internal class RiskGrupp
    {
        public RiskGrupp(int type)
        {
            Type = type;
        }

        public int Type { get; }

        public static RiskGrupp A => new RiskGrupp(1);
        public static RiskGrupp B => new RiskGrupp(2);
        public static RiskGrupp C => new RiskGrupp(3);

        public new bool Equals(object obj)
        {
            var riskGrupp = obj as RiskGrupp;
            return riskGrupp?.Type == Type;
        }
    }
}