using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindrromeFunction
{
    class Program
    {
        public static bool MyPalindromeFunction(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        public static void Main()
        {
            string[] myArray =  {"civic", "deified", "deleveled", "Perls", "Is", "Not", "A", "Palindrome", ""  };

            foreach (string word in myArray)
            {
                Console.WriteLine("{0} = {1}", word, MyPalindromeFunction(word));
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
