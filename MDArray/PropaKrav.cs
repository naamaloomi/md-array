namespace MDArray
{
    internal class PropaKrav
    {
        public PropaKrav(int type)
        {
            Type = type;
        }

        public int Type { get; }

        public static PropaKrav Valfri => new PropaKrav(1);
        public static PropaKrav ObligatoriskPerMotpart => new PropaKrav(2);
        public static PropaKrav ObligatoriskPerGrupp => new PropaKrav(3);

        public new bool Equals(object obj)
        {
            var krav = obj as PropaKrav;
            return krav?.Type == Type;
        }
    }
}
