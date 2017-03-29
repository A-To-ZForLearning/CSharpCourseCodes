using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Employee 
    {
        private Address address;

        public Employee(Address myadress)
        {
            address = myadress;
        }
        public void PrintEmplyees()
        {
            Console.WriteLine("I'm an Employee");
        }

       

    }
}
