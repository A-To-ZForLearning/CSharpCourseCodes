using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerOb = new Person();
            Address myAddressObj = new Address();
            Employee myEmplObj = new Employee(myAddressObj);

            myAddressObj.PrintAddress();
            myPerOb.PrintPerson();
            Console.ReadKey();
        }
    }
}
