using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Classes
{
    partial class EmployeesPart
    {
        public void PrintName() { Console.WriteLine($"Employee Name is {name}"); }
        public void PrintAddress() { Console.WriteLine($"Employee address is {address}"); }
        partial void MyAge()
        {
            Console.WriteLine($"Employee Age is {age}");
        }
        public void PrintDepartName() {
            Console.WriteLine($"Employee Department Name is {department}");
            MyAge();

        }
       
    }
}
