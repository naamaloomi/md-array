using System;
using System.Collections.Generic;
using System.Text;

namespace MDArray
{
    class Datcha
    {
        internal static int[,] Rules = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        public static bool ArObligatoriskt(Motpart motpart) {
            return motpart.Equals(Motpart.FastighetsBolag) || motpart.Equals(Motpart.Ovriga);
        }
    }
}
