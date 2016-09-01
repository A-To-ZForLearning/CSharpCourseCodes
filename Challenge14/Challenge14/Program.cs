using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Challenge 14
            //Q1 / Create Multiplication table from 1 - 5 for all numbers <=10
            Console.WriteLine(" //Q1 / Create Multiplication table from 1 - 5 for all numbers <=10\n");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(" Multiplication Table for {0}\n", i);
                for (int j=1; j <= 10; j++)
                {
                    Console.WriteLine(i +" * " + j + "= "+" {0}\n", i*j);
                }
                Console.WriteLine(" \t");
            }
            Console.ReadKey();




            //Q2 / Create Multiplication table from 1 - 6 for even number <=10
            Console.WriteLine(" //Q2 / Create Multiplication table from 1 - 6 for even number <=10\n");
            for (int i = 2; i <= 6; i+=2)
            {
                Console.WriteLine(" Multiplication Table for {0}\n", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " * " + j + "= " + " {0}\n", i * j);
                }
                Console.WriteLine(" \t");
            }
            Console.ReadKey();


            //Q3 / Create Multiplication table from 1 - 6 for odd number  <=10
            Console.WriteLine("  //Q3 / Create Multiplication table from 1 - 6 for odd number  <=10\n");
            for (int i = 1; i <= 6; i += 2)
            {
                Console.WriteLine(" Multiplication Table for {0}\n", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " * " + j + "= " + " {0}\n", i * j);
                }
                Console.WriteLine(" \t");
            }
            Console.ReadKey();



            /*  for more information visit
                     http://www.youtube.com/c/AToZForLearning 
            */
        }
    }
}
