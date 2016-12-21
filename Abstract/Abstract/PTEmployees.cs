using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    sealed class PTEmployees:Employees
    {
        public string shift;
        public override void PrintName()
        {
            Console.WriteLine($"{name}");
        }
        public override void PrintDepart()
        {
            Console.WriteLine($"{department = "PT Employees"}");
        }
    }
}
