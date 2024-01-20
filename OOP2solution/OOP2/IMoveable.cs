using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routOOP2
{
    interface IMoveable
    {
        void Forward();
        //void Backward();
        //void Left();
        //void Right();
    }
    interface IFlayable
    {
        void Forward();
        //void Backward();
        //void Left();
        //void Right();
    }
    class Airplane : IMoveable, IFlayable
    {

        void IMoveable.Forward()
        {
            Console.WriteLine("Mopve Forward on ground");
        }

        void IFlayable.Forward()
        {
            Console.WriteLine("Mopve Forward on Air");
        }
    }
}
