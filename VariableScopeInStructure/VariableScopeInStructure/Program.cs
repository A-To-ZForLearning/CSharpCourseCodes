using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableScopeInStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, index=0;
            for (i = 0; i < 10; i++)
            {
                 index = i;
                Console.WriteLine($"{index}");
            }
            Console.WriteLine($"Last index output in loop: {index}");
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
