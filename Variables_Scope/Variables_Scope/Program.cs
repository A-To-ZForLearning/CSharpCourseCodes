using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Scope
{
    class Program
    {
        static string myString2;
        static void printMyString()
        {
            string myString = "My String inside the printMyString Method ";
            Console.WriteLine($"{myString}");
            Console.WriteLine($"{ myString2}");

        }

        static void Main(string[] args)
        {
            string myString = "My String inside the Main Method";
           myString2 = "Global myString variable";
            printMyString();

            Console.WriteLine($"{myString}");
            Console.WriteLine($"{ myString2}");
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
