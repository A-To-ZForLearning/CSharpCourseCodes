using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myNumbers = {
                                 { 1, 2, 3, 4 },
                                 { 2, 3, 4, 5 },
                                 { 3, 4, 5, 6 }
                               };

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("{0}", myNumbers[i, j] + " ");
            //    }
            //}
            foreach (int item in myNumbers)
                Console.WriteLine("{0}", item + " ");

                //Console.WriteLine("");

            //    int[,,] myArray3Da = new int[2, 2, 3]
            //    { 
            //        {
            //                  { 1, 2, 3 }, { 4, 5, 6 }
            //        },

            //         {
            //                  { 7, 8, 9 }, { 10, 11, 12 }
            //         }

            //    };

            //}


            //Q24 // Define a 3D array and print the values using 3 for loop

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
