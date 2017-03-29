using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InclusionPolymorphsim
{
    class HuRes :Employees
    {
        public override void PrintName()
        {
            Console.WriteLine("\nI'm print from class Human Resources\n");
        }
    }
}
