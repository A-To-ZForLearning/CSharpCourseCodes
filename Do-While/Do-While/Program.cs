using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {

            double mySalary = 1000.20, total = 0.0;
            int i = 0;
            do
            {
               total +=  mySalary;   //total = total  + mySalary;
               i++;
                Console.WriteLine("i values equal {0}",i);
            } while (i < 10);
            Console.WriteLine("Salary values equal {0}", total);

            Console.ReadKey();



       //Q1 Find how many years do you need to reach $2000 if your salary was $1020 and the increment percentage
        // was $20 per month and print the result;






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
