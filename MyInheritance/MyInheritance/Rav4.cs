using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyInheritance
{
    public class Rav4 : Car
    {
        public void PrintModel() { Console.WriteLine(model = "RAV4"); }
        public int engineSize
        {
            get
            {
                return engineSize;
            }

            set
            {
            }
        }
    }
}