using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routeOOP01.inheritance
{
    internal class Child:parent
    {
        public int z { get; set; }

        public Child (int _x, int _y , int _z):base(_x, _y)
        {
            z = _z;
        }
        public override string ToString()
        {
            return $"{x}  , {y} , {z} ";
        }
        public new int product()
        {
            //return x*y*z;
            return base.product() * z;
        }

    }
}
