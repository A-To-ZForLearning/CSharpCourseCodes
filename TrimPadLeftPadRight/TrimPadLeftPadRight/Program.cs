using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimPadLeftPadRight
{
    class Program
    {
        static void Main(string[] args)
        {

                string myString, myString2;

                char[] mytrimChar = { 'h','e', 'i', ' ' };
                Console.WriteLine("Please Enter Your String");
                myString = Console.ReadLine();
                myString = myString.ToLower();
                myString2 = myString.TrimStart(mytrimChar);
                Console.WriteLine($"{myString2}");
                myString2 = myString.TrimEnd(mytrimChar);
               Console.WriteLine($"{myString2}");

               myString2 = myString.PadLeft(25, ' ');
                Console.WriteLine($"{myString2}");
                myString2 = myString.PadRight(25, 'k');
                Console.WriteLine($"{myString2}");

            Console.ReadKey();
            //Q24
            //Change this string from this style "Hello My Dear" to be 
            //in this style "Hello My Dearest" using pads functions only

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
