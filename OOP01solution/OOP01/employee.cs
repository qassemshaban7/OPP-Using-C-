using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routeOOP01
{
    internal struct employee
    {
        public int empid;
        private string empname;
        private decimal empsalary;

        public decimal Salary
        {
            get 
            {
                return empsalary; 
            } 
            set 
            {
                empsalary = value >=2000  ? value: 2000;
            }
        }
        ////automatic property
        //public int age { get; set; }
        ////full property
        //private int age;
        //public int age
        //{
        //    get { return age; }
        //    set { age = value }
        //}
        ////propfull   to creat full property
        ////prop       to creat automatic property


        public employee(int _id, string _name, decimal _salary)
        {
            empid = _id;
            empname = _name;
            empsalary = _salary;

        } 
        //getter for name 
        public string GetName()
        {
            return empname;
        }
        //setter for name 
        public void SetName(string value)
        {
            empname = value.Length <= 10 ? value :value .Substring(0,10);
        }
        // method
        public override string ToString()
        {
            return $"{empid} :: {empname} :: {empsalary}";
        }
    }
}
