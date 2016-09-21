using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameters
{
    class Program
    {
        static int MinValue(int[] myArray2, out int myIndex)
        {
            int minVal = myArray2[0];
            myIndex = 0;
            for (int i = 1; i < myArray2.Length; i++)
            {
                if (myArray2[i] < minVal)
                {
                    minVal = myArray2[i];
                    myIndex = i;
                }
                 
               
            }
            return minVal;
        }
        static void Main(string[] args)
        {
            int myIndex;
            int[] myArray = { 1, 10, 43, 6, 22, 8, 9, 13, 50,22 };
            int minVal = MinValue(myArray, out myIndex);
            Console.WriteLine($"The minimum value in myArray is {minVal} and the Index is {myIndex}");
            Console.ReadKey();





            /*  

            for more information visit
                     http://www.youtube.com/c/AToZForLearning 

           Visit our channel page on facebook
                     https://www.facebook.com/AToZForLearning/

           If you have any question in English or Arabic welcome to our facebook group 
                     https://www.facebook.com/groups/AToZForLearningProgramming/  


                     */



            //Q28/ Write a program to use the Out Parameter

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
