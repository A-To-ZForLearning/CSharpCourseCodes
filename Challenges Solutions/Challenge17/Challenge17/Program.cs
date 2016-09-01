using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q17/ Define a decimal variable and then convert it to an Integre variable using 
            //either Implicit or Explicit conversion operations and use checked keyword to through 
            // an exception of overflow type

            decimal myvar = 300;
            byte myIntVar;
            myIntVar = checked((byte)myvar);
            Console.WriteLine($"My Integer variable is {myIntVar}");
            Console.ReadKey();

            /*  

for more information visit
         http://www.youtube.com/c/AToZForLearning 

Visit our channel page on facebook
         https://www.facebook.com/AToZForLearning/

If you have any question in English or Arabic welcome to our facebook group 
         https://www.facebook.com/groups/AToZForLearningProgramming/  


         */

        }
    }
}
