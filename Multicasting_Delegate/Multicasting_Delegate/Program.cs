using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicasting_Delegate
{
    delegate int MyNewNumber(int myNumber);
    class Program
    {
        static int myXNumber = 3;
        static int addFunct(int number)
        {
            myXNumber += number;
            return myXNumber;
        }
        static int mulFunc(int number)
        {
            myXNumber *= number;
            return myXNumber;
        }
        static void Main(string[] args)
        {
            MyNewNumber n;
            MyNewNumber n1 = new MyNewNumber(addFunct);
            MyNewNumber n2 = new MyNewNumber(mulFunc);
            n1(4);
            Console.Write($"{myXNumber}\n");
            n2(5);
            Console.Write($"{myXNumber}\n");

            n = n1 + n2;
            n(5);
            Console.Write($"{myXNumber}");
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
