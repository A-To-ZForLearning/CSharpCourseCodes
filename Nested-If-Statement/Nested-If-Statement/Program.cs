using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {


            int myVar1 = 9, myVar2 = 6;

            if (myVar1 == 10)
            {
                Console.WriteLine("myVar1 equal 9");
                if (myVar2 == 6)
                {
                    Console.WriteLine("myVar2 == 6");
                }
                else
                {
                    Console.WriteLine("myVar2 is not equal 7");
                }
            }
            else
            {
                Console.WriteLine("myVar1 not equal 9");
            }

            Console.ReadKey();


            /*
              Q1/ Define 3 variables myVar1 =10, myVar2 =6 myVar3 = 8

           and check the values using nested if-else statement

            1- (myVar1 ==10)   print a statement
            2- ((myVar2 >= 5)&&(myVar3 <= 9))
            and print else for each one of them
               
              
              
              
              */









            /* for more information go to A-To-Z ForLearning channel in this link https://goo.gl/7SCOj3 */
        }
    }
}
