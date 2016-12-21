using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassDiagram
{
    class Nissan:Cars
    {
        public string make = "Nissan";

        public override void PrintMake()
        {
            Console.WriteLine($"{make}");
        }
    }
}
