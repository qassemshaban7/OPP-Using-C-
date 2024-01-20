using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace routeOOP01
{
    internal struct point
    {
        ///attrubutes 
        public int x, y;
        ///constructor : is a special function 
        ///[his name is the same name of struct and not return typr]
        /// when you creat user defiend constructot ,you must intialize all atrubutes of struct inside its body

        public point(int _x ,int _y)
        {
            x=_x ; 
            y=_y;
        }
        //public point(int x, int y)
        //{
        //    this.x = x;
        //    this.y = y;
        //}
        public point (int number)
        {
            x = y = number;
        }
        //method
        public override string ToString()
        {
            return $"({ x},{ y})";

        }

        
    }
}
