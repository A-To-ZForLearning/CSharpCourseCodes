using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamertersVsArguments
{
    class Program
    {
        static void addNumbers(int myFirstNumber, int mySecondNumber)
        {
            int temp = myFirstNumber + mySecondNumber;
            Console.WriteLine($"{temp}");
        }

        static int addNumbers2(int myFirstNumber, int mySecondNumber)
        {
            int temp = myFirstNumber + mySecondNumber;
            return temp;
        }
        static void Main(string[] args)
        {
            int myVar1 = 5, myVar2 = 3;

            addNumbers(myVar1, myVar2);

             
            Console.WriteLine($"{addNumbers2(myVar1, myVar2)}");
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
