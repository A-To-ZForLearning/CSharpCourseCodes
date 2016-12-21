using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Toyota myObj = new Toyota();
            myObj.make = "Ford";
            myObj.year = "2016";
            myObj.PrintModel();
            myObj.PrintEngineSize();
            Console.WriteLine($"{myObj.make}");

            Console.ReadKey();
        }
    }
}
