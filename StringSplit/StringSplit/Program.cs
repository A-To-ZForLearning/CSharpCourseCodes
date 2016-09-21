using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;
            char[] separator = { ' ', 'u' };
            myString = Console.ReadLine();
            string[] myNewWords;
            myNewWords = myString.Split(separator);
            foreach (string word in myNewWords)
            {
                Console.WriteLine($"{word}");
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
