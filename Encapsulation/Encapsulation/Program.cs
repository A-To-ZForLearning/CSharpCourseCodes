using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string myVar1, myVar2;
            EncapsulationClass myobj = new EncapsulationClass();
            myVar1 = myobj.get1();
            myVar2 = myobj.get2();
            Console.WriteLine($"{myVar1} {myVar2}");
            myobj.PrintFullName();
            myobj.PrintAge();

            Console.ReadKey();
            
        }
    }
}
