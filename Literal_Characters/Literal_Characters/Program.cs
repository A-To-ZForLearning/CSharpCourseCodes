using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = -100;
            uint myUVar = 1000U;
        
            float myFlVar = 1.5F;
            double myDVar = 100.5;
            decimal myDecVar = 100.5m;

            Console.WriteLine("{0} {1}", myVar, myUVar);
            Console.WriteLine($"{myDecVar}, {myDVar}");
            Console.ReadKey();

         /*  
  
 for more information visit
          http://www.youtube.com/c/AToZForLearning 
		  
Visit our channel page on facebook
          https://www.facebook.com/AToZForLearning/

If you have any question in English or Arabic welcome to our facebook group 
          https://www.facebook.com/groups/AToZForLearningProgramming/  
			  
		  
		  */}
    }
}
