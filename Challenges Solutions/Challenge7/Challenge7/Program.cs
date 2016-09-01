using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge7
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 =9, myVar2 =11  ;
            bool myConditionResult;

            myConditionResult = ((myVar1 <= 9) && (myVar2 <= 11));
            Console.WriteLine("The Result of my condition is {0}", myConditionResult);
            myConditionResult = ((myVar1 <= 9) || (myVar2 <= 11));
            Console.WriteLine("The Result of my condition is {0}", myConditionResult);

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
