using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routeOOP01
{
    internal class typeA
    {
        public int A { get; set; }
        public typeA(int _A)
        {
            A = _A;
        }
        // static binded method
        public void staticBindedShow()
        {
            Console.WriteLine("I am Base [Parent]");
        }
        //dynamic binded method 
        public virtual void DynamicBindedMethod()
        {
            Console.WriteLine($"TypeA {A}");
        }
    }
    class typeB:typeA
    {
        public int B { get; set; }
        public typeB(int _A, int _B):base(_A)
        {
            B = _B; 
        }
        public new void staticBindedShow()
        {
            Console.WriteLine("I am Derived [Child1]");
        }
        public override void DynamicBindedMethod()
        {
            Console.WriteLine($"TypeB {A} {B}");
        }
    }
    class typeC:typeB
    {
        public int C { get; set; }
        public typeC(int _A , int _B ,int _C):base(_A,_B)
        {
            C = _C;          
        }
        public new void staticBindedShow()
        {
            Console.WriteLine("I am Derived [Child2]");
        }
        //dynamic binded method 
        public override void DynamicBindedMethod()
        {
            Console.WriteLine($"TypeC {A} {B} {C}");
        }
    }
}
