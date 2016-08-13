using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - / * %

            int myvar1 = 15;
            int myVar2 = 10;
            int temp = myvar1 + myVar2;
            int temp2 = myvar1 - myVar2;
            int temp3 = myvar1 % myVar2;


            // + -
            int myNegtiveVar = -10;

            int temp4 = + myvar1;
            int temp5 = -myvar1;
            int temp6 = +myNegtiveVar;
            Console.WriteLine("{0}\n\n{1}\n\n{2}", temp4, temp5, temp6);
            //Console.WriteLine("The result is {0}  The result2 is {1} The remaining is {2}", temp, temp2, temp3);
            Console.ReadKey();

          /* for more information go to A-To-Z ForLearning channel in this link https://goo.gl/7SCOj3 */
        }
    }
}
