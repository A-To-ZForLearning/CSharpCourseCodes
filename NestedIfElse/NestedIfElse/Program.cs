using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIfElse
{
    class Program
    {
        static void Main(string[] args)
        {

            int myVar = 4, myVar2 = 6;
            if (myVar <= 3 && myVar2 >= 5)
            {
                Console.WriteLine("Condition one right");
            }
            else if (myVar <= 4 && myVar2 >= 6)
            {
                Console.WriteLine("Condition two right");
            }
            else if (myVar2 > 5)
            {
                Console.WriteLine("Condition three right");
            }
            else
            {
                Console.WriteLine("No one of the conditions");

            }
            Console.ReadKey();
			
			  /*  for more information visit
          http://www.youtube.com/c/AToZForLearning 
       */
        }
    }
}
