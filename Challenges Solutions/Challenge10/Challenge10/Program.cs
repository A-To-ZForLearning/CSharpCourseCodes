using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge10
{
    class Program
    {
        static void Main(string[] args)
        {
            string whatHeSay = "Hello";

            switch (whatHeSay)
            {
                case "hello":
                    Console.WriteLine("My animal is the canary bird");
                    break;
                case "Bye":
                    Console.WriteLine("My animal is a cat");
                    break;
                case "welcome":
                    Console.WriteLine("My animal is a camel");
                    break;

                default:
                    Console.WriteLine("no one");
                    break;

            }
            /*  for more information visit
        http://www.youtube.com/c/AToZForLearning 
     */
            Console.ReadKey();
        }
    }
}
