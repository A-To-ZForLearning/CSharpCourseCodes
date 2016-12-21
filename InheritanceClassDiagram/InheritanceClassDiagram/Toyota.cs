using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceClassDiagram
{
    public class Toyota : Cars 
    {
        public int engineSize = 4;
        public string make = "Toyota";

        public void PrintEngineSize()
        {
            Console.WriteLine($"{engineSize}");
        }

        public override void PrintMake()
        {
            Console.WriteLine($"{make}");
        }
    }
}