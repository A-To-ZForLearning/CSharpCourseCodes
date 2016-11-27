using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFunction
{
    class Program
    {
        static int MyRecursiveFunction(int myValue, ref int counter)
        {
            counter++;
            //if value = 0
            if (myValue == 0)
                return 0;
            //if value less than 10
            else if (myValue < 10)
            {
               return MyRecursiveFunction(myValue + 1, ref counter); 
                
            }
            //if value equal or exceeds 10
            return myValue;   
        }
        static void Main(string[] args)
        {
            int counter = 0, myResult;
            myResult = MyRecursiveFunction(4, ref counter);
            Console.WriteLine($"My Result is {myResult} and Counter value is {counter}");
            Console.ReadKey();



            //Challenge 32 
            // Find Factorial the number n where n =5;



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
