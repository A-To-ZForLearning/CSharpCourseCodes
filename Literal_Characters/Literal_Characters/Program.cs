using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = -100;
            uint myUVar = 1000U;
        
            float myFlVar = 1.5F;
            double myDVar = 100.5;
            decimal myDecVar = 100.5m;

            Console.WriteLine("{0} {1}", myVar, myUVar);
            Console.WriteLine($"{myDecVar}, {myDVar}");
            Console.ReadKey();

          /* for more information go to A-To-Z ForLearning channel in this link https://goo.gl/7SCOj3 */
        }
    }
}
