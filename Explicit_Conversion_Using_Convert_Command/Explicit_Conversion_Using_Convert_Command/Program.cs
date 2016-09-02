using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversion_Using_Convert_Command
{
    class Program
    {
        static void Main(string[] args)
        {

            double myDoubleVar = 2500.45D;

            string myStringvar, mySubString;

            // myStringvar = myDoubleVar;             //Implicit Conversion

            myStringvar = Convert.ToString(myDoubleVar);

            mySubString = myStringvar.Substring(0,2);
            
            Console.WriteLine($"My Variable is {myDoubleVar}\n");
            Console.WriteLine("My String Variable is {0}  \n My String Variable is {1}", myStringvar, mySubString);
            Console.ReadKey();




            //Q18/ Define a float vairable and assign the value 45.56f and convert it to string
            //and print the numbers start from the float point 

            
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
