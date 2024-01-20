using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routeOOP01.interfaces
{
    internal interface ISeries
    {
        public int Current { get; }
        void GetNext();
        void Reset();
    }
    class SeriesByTwo : ISeries
    {
        //int current
        //public int Current
        //{
        //    get
        //    {
        //        return current;
        //    }
        //}
        public int Current { get; set; }
        public void GetNext()
        {
            Current += 2;
        }
        public void Reset()
        {
            Current = 0;
        }
    }
    class SeriesByThree : ISeries
    {
        public int Current { get; set; }
        public void GetNext()
        {
            Current += 3;
        }
        public void Reset()
        {
            Current = 0;
        }
    }
    class SeriesByFour : ISeries
    { 
        public int Current { get; set; }
        public void GetNext()
        {
            Current += 4;
        }
        public void Reset()
        { 
            Current = 0;
        }
    }
}
