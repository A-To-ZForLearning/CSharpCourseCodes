using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myAnimal = "Cat";

            //switch (myAnimal)
            //{
            //    case "Canary":
            //        Console.WriteLine("My animal is the canary bird");
            //        break;
            //    case "Cat":
            //        Console.WriteLine("My animal is a cat");
            //        break;
            //    case "Camel":
            //        Console.WriteLine("My animal is a camel");
            //        break;

            //    default:
            //        Console.WriteLine("no one");
            //        break;

            //}

            int myVar = 15;
            switch (myVar)
            {
                case 10:
                    Console.WriteLine("My Variable number value is 10");
                    break;
                case 7:
                    Console.WriteLine("My Variable number value is 7");
                    break;
                case 15:
                    Console.WriteLine("My Variable number value is 15");
                    break;

                default:
                    Console.WriteLine("no one");
                    break;

            }

            //Challenge 10
            //Define a string variable whatHesay and assign the value "Hello" and check what the variable 
            //value among these cases  "hello", "Bye", "welcome" or NoOne is the defult and print the rsult 
            // and Why?

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
