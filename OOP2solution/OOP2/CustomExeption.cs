using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routOOP2
{
    internal class CustomExeption :Exception
    {
        public CustomExeption(): base("Message Of Custom Exeption")
        {

        }
    }
}
