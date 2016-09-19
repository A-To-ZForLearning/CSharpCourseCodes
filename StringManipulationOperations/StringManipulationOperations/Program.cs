using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            string myString = "Hello My Friends";
            char[] myCharArray = myString.ToCharArray();

            Console.WriteLine($"The String Length is {myString.Length}\n");

            foreach (char mychar in myCharArray)
            {

                Console.WriteLine($"{mychar}");
            }
            Console.ReadKey();
        }
    }
}
