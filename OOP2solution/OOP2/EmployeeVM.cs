using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routOOP2
{
    internal class EmployeeVM
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public static explicit operator EmployeeVM(employee employee)
        {
            string[] Names = employee?.FullName.Split(" ");
            return new EmployeeVM()
            {
                FName = Names[0],
                LName = Names[1]
            };
        }
    }
}
