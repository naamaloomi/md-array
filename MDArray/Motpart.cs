namespace MDArray{
    class Motpart{
        public Motpart(int type) {
            Type = type;
        }

        public int Type { get; }

        public static Motpart FastighetsBolag => new Motpart(1);
        public static Motpart Brf => new Motpart(2);
        public static Motpart Ovriga => new Motpart(3);

        public new bool Equals(object obj) {
            var motpart = obj as Motpart;
            return motpart?.Type == Type;
        }
    }
}