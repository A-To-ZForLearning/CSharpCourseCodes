using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace AssertMethod
{
    class Program
    {
        static void Main(string[] args)
        {
           
            WriteLine($"Enter a Value");
            int i = Convert.ToInt32(ReadLine());
            if (i >= 100)
            {
                WriteLine($"{i}");
            }
            else
            {
                Debug.WriteLine("We are Here");
                Debug.Assert(i >=100, "Short", "Long");
                Trace.Assert(i >= 100, "Short", "Long");

            }
            WriteLine("Done ");

            ReadKey();
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
