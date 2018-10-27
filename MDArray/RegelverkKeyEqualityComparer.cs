using System.Collections.Generic;

namespace MDArray
{
    public class RegelverkKeyEqualityComparer : IEqualityComparer<(Motpart, RiskGrupp, Bransch)>
    {
        public bool Equals((Motpart, RiskGrupp, Bransch) x, (Motpart, RiskGrupp, Bransch) y)
        {
            return
                x.Item1.Equals(y.Item1) &&
                x.Item2.Equals(y.Item2) &&
                x.Item3.Equals(y.Item3);
        }

        public int GetHashCode((Motpart, RiskGrupp, Bransch) obj)
        {
            return
                obj.Item1.GetHashCode() +
                obj.Item2.GetHashCode() +
                obj.Item3.GetHashCode();
        }
    }
}