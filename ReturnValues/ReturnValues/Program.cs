using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValues
{
    class Program
    {
        static int MinValue(int[] myArray2)
        {
            int minVal = myArray2[0];
            for (int i = 1; i < myArray2.Length; i++)
            {
                if (myArray2[i] < minVal)
                    minVal = myArray2[i];
            }
            return minVal;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 11, 10, 3, 6, 2, 8, 9, 3, 50, 2 };
            int minVal = MinValue(myArray);
            Console.WriteLine($"The minimum value in myArray is {minVal}");
            Console.ReadKey();


            //Q26/ Define a function to find the avarage
            //of a student that has 7 grades and print the
            //result in the void main

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
