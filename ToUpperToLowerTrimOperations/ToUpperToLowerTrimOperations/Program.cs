using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpperToLowerTrimOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString, myString2;

            //myString2 = myString.ToUpper();
            //Console.WriteLine($"{myString2}");
            //Console.WriteLine($"{myString2}");
            char[] mytrimChar = { 'h', 'e', 'i', ' '};
            Console.WriteLine("Please Enter Your String");
            myString = Console.ReadLine();
            myString = myString.ToLower();
            myString2 = myString.Trim(mytrimChar);
            Console.WriteLine($"{myString2}");

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
