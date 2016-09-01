using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Loop_BreakCommand
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Hello Nazar");
                if (i > 2)
                    continue;

                for (int j = 0; j <= 4; j++)
                {
                    Console.WriteLine("\t Hello World");
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();



            //Q16/ Same Q/15 using continue command


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
