using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static int Main(string[] args)
        {

            Console.WriteLine($"{args.Length} command line arguments has entered:");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.ReadKey();
            return 0;
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
