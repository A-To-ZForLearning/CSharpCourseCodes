using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge9
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 10, myVar2 = 6, myVar3 = 8;
            if (myVar1 == 10)
            {
                Console.WriteLine("My variable equal 10");
            }
            else
            {
                Console.WriteLine("My Variable is not equal 10");
            }
            if ((myVar2 >= 5) && (myVar3 <= 9))
            {
                Console.WriteLine("My Variable 2 is >= 5 and my Variable 3 is <=9");
            }
            else
            {
                Console.WriteLine("My variables didn't match the conditions");
            }
            /* for more information go to A-To-Z ForLearning channel in this link https://goo.gl/7SCOj3 */
            Console.ReadKey();
        }

    }
}
