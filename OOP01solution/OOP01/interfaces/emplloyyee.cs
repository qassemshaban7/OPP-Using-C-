using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routeOOP01.interfaces
{
    internal class emplloyyee:ICloneable,IComparable
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public decimal Salary { get; set; }
        /// copy constructor
        public emplloyyee(emplloyyee empCopy)
        {
            this.Id = empCopy.Id;
            this.FullName = empCopy.FullName;
            this.Salary = empCopy.Salary;
        }
        public emplloyyee()
        {
                
        }
        public object Clone()
        {
            return new emplloyyee()
            {
                Id = this.Id,
                FullName = this.FullName,
                Salary = this.Salary
            };
        }
        public override string ToString()
        {
            return $" {Id} :: {FullName} :: {Salary}";
        }

        public int CompareTo(object obj)
        {
            emplloyyee other = (emplloyyee)obj;
            if (this.Salary > other.Salary)
                return 1 ;
            else if(this.Salary <other.Salary)
                return -1 ;
            else 
                return 0 ;
        }
    }
}
