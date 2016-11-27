using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        public static void PrintValues(string name = "Nazar Al-Wattar", int myValue = 7)
        {
            Console.WriteLine($"Name  = {name}  Number  = {myValue}");

        }

        static void Main(string[] args)
        {
            string name = "Ahmed";
            int value = 15;
            PrintValues();
            PrintValues(name);
            PrintValues(name, value);
            PrintValues(name: "Basim", myValue: 6);
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
