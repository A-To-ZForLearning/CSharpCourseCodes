using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challnge27
{
    class Program
    {
        static void DoubleNum(ref int val, ref int val2)
        {
            val *= 2;
            val2 *= 4;
            Console.WriteLine($"myNumber = {val}");
        }


        static void Main(string[] args)
        {

            int myNumber = 5, myNumber2 = 4;
            Console.WriteLine($"myNumber = {myNumber}");
            DoubleNum(ref myNumber, ref myNumber2);
            Console.WriteLine($"myNumber = {myNumber},{myNumber2}");
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
