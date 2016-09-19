using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopVsForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFullName = { "Nazar", "Hussein", "Al-Wattar" };
            int myArraylength = myFullName.Length;

            //for (int i = 0; i < myArraylength; i++)
            //{
            //    myFullName[2] = "Ahmed";
            //    Console.Write($"{myFullName[i]}" + " ");

            //}
            //Console.WriteLine("\nMy Array Length is " + $"{myArraylength}");

            foreach (string myname in myFullName)
            {
                myname = "Ahmed";
                Console.Write($"{myname}" + " ");

            }
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
