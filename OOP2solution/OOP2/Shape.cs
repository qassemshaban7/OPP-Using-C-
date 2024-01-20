using routOOP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routOOP2
{ 
    internal abstract class Shape
    {
        public int Dim01 { get; set; } //automatic property
        public int Dim02 { get; set; }
        public abstract int CalcArea();
        public abstract int Primeter { get; }
    }
}
abstract class RectBase : Shape
{
    public override int CalcArea()
    {
        return Dim01 * Dim02;
    }

}
class Rect : RectBase
{
    public override int Primeter 
    {
         get { return (Dim01+Dim02) * 2; }
    }
}
class Square : RectBase
{
    public override int Primeter
    {
        get { return Dim01 * 4; }
    }
}
