namespace MDArray
{
    public class Bransch
    {
        public Bransch(int type)
        {
            Type = type;
        }

        public int Type { get; }

        public static Bransch A => new Bransch(1);
        public static Bransch B => new Bransch(2);
        public static Bransch C => new Bransch(3);

        public new int GetHashCode()
        {
            return Type;
        }

        public bool Equals(Bransch bransch)
        {
            return Type == bransch.Type;
        }
    }
}