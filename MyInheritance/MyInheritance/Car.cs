using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyInheritance
{
    public class Car
    {
        public string model = "RAV45";
        public string color;
        public string make;

        public void PrintModel()
        {
            Console.WriteLine($"{model}");
        }
    }
}