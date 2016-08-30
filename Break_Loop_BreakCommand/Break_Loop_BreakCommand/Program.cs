using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Loop_BreakCommand
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Hello Nazar");
                if (i > 2)
                    break;

                for (int j = 0; j <= 4; j++)
                {
                    Console.WriteLine("\t Hello World");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();



            //Q15/ Create Multiplication table for number in the range 1-10
            // and stop the loop in the multiplication table for the number 7 from 1-10;


 /*  for more information visit
          http://www.youtube.com/c/AToZForLearning 
 */
        }
    }
}
