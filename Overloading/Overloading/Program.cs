using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        public static int printNumber(int myNumber)
        {

            return myNumber;
        }
        public static double printNumber(double myNumber)
        {
            return myNumber;
        }
        static void Main(string[] args)
        {
            int myNumber = 9;
            Console.Write($"{printNumber(myNumber)}");
            Console.ReadKey();
            /*  

for more information visit
         http://www.youtube.com/c/AToZForLearning 

Visit our channel page on facebook
         https://www.facebook.com/AToZForLearning/

If you have any question in English or Arabic welcome to our facebook group 
         https://www.facebook.com/groups/AToZForLearningProgramming/  


         */

            //Q29
            //Define two functions using overloading concepts to return the minimum value of an 
            //array with 10 numbers once as integer and once as double value and print the result
        }
    }
}
