using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Rav4 myRav4 = new Rav4();
            myRav4.model = "RAV34";
            myRav4.PrintModel();
           
            Console.ReadKey();
        }
    }
}
