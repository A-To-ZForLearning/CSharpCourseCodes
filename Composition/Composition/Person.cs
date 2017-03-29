using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Person 
    {
        Employee myEmpObj = new Employee();
        
        public void PrintPerson()
        {
            myEmpObj.PrintEmplyees();

            Console.WriteLine("\nI'm a Person");
        }
    }
}
