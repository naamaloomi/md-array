﻿namespace MDArray
{
    internal class PropaKrav
    {
        public PropaKrav(int type, string name)
        {
            Type = type;
            Name = name;
        }

        public int Type { get; }
        public string Name { get; }

        public static PropaKrav Valfri => new PropaKrav(1, "Valfri");
        public static PropaKrav ObligatoriskPerMotpart => new PropaKrav(2, "Obligatorisk per motpart");
        public static PropaKrav ObligatoriskPerGrupp => new PropaKrav(3, "Obligatorisk per grupp");

        public new bool Equals(object obj)
        {
            var krav = obj as PropaKrav;
            return krav?.Type == Type;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
