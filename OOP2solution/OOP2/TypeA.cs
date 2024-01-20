using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routOOP2
{
    class GrandParent
    {
        public virtual void Print()
        {
            Console.WriteLine("GrandParent");
        }
    }
    class Parent :GrandParent
    {
        public override void Print()
        {
            Console.WriteLine("Parent");
        }
    }

    //you can not inhirt from seald class 
    sealed class Child : Parent
    {
        //you can not override to seald method
        public sealed override void Print()
        {
            Console.WriteLine("Child");
        }
    }
    partial class Car
    {
        public int Id { get; set; }
    }
    partial class Car
    {
        public string Model { get; set; }
    }
}
