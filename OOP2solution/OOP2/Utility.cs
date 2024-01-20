using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routOOP2
{
    internal class Utility
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Utility(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        public override string ToString()
        {
            return $"({X} ,{Y})";
        }
        //class method
        public static double Cm2Inche(double Cm)
        {
            return Cm / 2.54;
        }

    }
}
