using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceClassDiagram
{
    public class Cars
    {
        public string engineCapacity = "2.4L";
        public string drivingType = "4WD";

        public void PrintengineCaoacity()
        {
            Console.WriteLine($"{engineCapacity}");
        }
        public virtual void PrintMake()
        {
            Console.WriteLine($"{drivingType}");

        }
    }
}