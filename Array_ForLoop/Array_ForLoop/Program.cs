using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
          const  int myArraySize = 5;
            int[] myNumbers = { 1, 5, 8, 9, 7 };
            int[] myNumbers2 = new int[myArraySize];
            int[] myNumbers3 = new int[myArraySize] {1,5,8,9,7 };

            for(int i=0; i<5;i++)
            Console.WriteLine("My numbers " + (i + 1) + "= " + $"{myNumbers[i]}" + " ");
            Console.ReadKey();


            //Q22/ Define an array of int type and find the max value 




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
