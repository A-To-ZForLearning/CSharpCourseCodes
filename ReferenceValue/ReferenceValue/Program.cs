using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceValue
{
    class Program
    {
        static void MultiplyNum(ref int myVar)
        {
            myVar *= 3;
            Console.WriteLine($"myNumber = {myVar}"); ;
        }


        static void Main(string[] args)
        {

            int myNumber = 5;
            Console.WriteLine($"myNumber = {myNumber}");
            MultiplyNum(ref myNumber);
            Console.WriteLine($"myNumber = {myNumber}");
            Console.ReadKey();

            //Q27 define a function that accept two paramerters 
            //as refernce values and change them using multiplication
            //by 4 and print the result before and after multiplication

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
