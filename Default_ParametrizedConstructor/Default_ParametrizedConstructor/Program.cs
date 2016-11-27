using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_ParametrizedConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Ahmed Ali" , myName2 = "Amjed";
            int age2 = 30;
            Person myObj = new Person();
            myObj.PrintValues();
                       
            Console.WriteLine();
            Person myObj2 = new Person(myName, age2);
            myObj2.PrintValues();

            Console.WriteLine();
            Person myObj3 = new Person(myName2);
            myObj3.PrintValues();
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
