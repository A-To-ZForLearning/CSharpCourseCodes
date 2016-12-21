using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Cars
    {
        //The relation is "is a kind"
        public string model = "Camery";
        public string make = "Toyota";
        public string year;
        public void PrintModel() { Console.WriteLine($"{model}"); }
    }
}
