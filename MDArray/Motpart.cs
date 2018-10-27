namespace MDArray
{
    public class Motpart
    {
        public Motpart(int type)
        {
            Type = type;
        }

        public int Type { get; }

        public static Motpart FastighetsBolag => new Motpart(1);
        public static Motpart Brf => new Motpart(2);
        public static Motpart Ovriga => new Motpart(3);

        public new int GetHashCode()
        {
            return Type;
        }

        public bool Equals(Motpart motpart)
        {
            return Type == motpart.Type;
        }
    }
}