using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace routeOOP01.inheritance
{
    internal class parent
    {
        public int x { get; set; } 
        public int y { get; set; }


        public parent(int _x , int _y)
        {
            x= _x;
            y= _y;
        }
        public override string ToString()
        {
            return $"{x} , {y}";
        }
        public int product()
        {
            return x*y;
        }

    }
}
