using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge8
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 8;
            if (myVar1 >= 10)
            {
                Console.WriteLine("My variable is greater than 10");
            }
            else
            {
                Console.WriteLine("My variable is less than 10");
            }

                myVar1 = 10;
            int myVar2 =5, myVar3 = 9;

            bool myResult = (myVar1 <= 11) || (myVar2 == 5) && (myVar3 >= 8);
            Console.WriteLine("The condition result is {0}", myResult);



            myResult = (myVar1 <= 11) || (myVar2 == 6) && (myVar3 >= 8);

            Console.WriteLine("The condition result is {0}", myResult);



            /*  for more information visit
               http://www.youtube.com/c/AToZForLearning 
            */


            Console.ReadKey();
        }
    }
}
