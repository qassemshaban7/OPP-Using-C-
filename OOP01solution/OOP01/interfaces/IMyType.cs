using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routeOOP01.interfaces
{
    internal interface IMyType
    {
        ///what i can write 
        ///1.signature for method 
        ///2.signature for property 
        ///3.default implemented method (c# 8.0)

        ///default access modefier inside interface  is public 
        ///private access modefier is not allowed inside interface 

        ///1.signature for method 
        void myfun();

        ///2.signature for property 
        public int Salary { get; set; }
        ///3.default implemented method (c# 8.0)
        void print()
        {
            Console.WriteLine("hello default imlemented method c# 8.0 feature");
        }
    }

    class MyType : IMyType
    {
        //automatic property
        public int Salary { get; set; }

        //int salary;
        //public int  Salary 
        //{
        //    get
        //    {
        //        return Salary;
        //    }
        //    set
        //    {
        //        salary = value;
        //    }
        //}
        public void myfun()
        {
            Console.WriteLine("hello mytype ");
        }
    }
}
