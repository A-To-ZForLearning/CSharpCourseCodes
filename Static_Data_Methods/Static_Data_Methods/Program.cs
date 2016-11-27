using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Data_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StaticData_and_Mehtods s1 = new StaticData_and_Mehtods(50);
                      

            // Print the current interest rate.
            Console.WriteLine("Interest Rate is: {0}", StaticData_and_Mehtods.GetValue());
            StaticData_and_Mehtods.SetInterestRate(0.7);

            //Even If we make new object, this does NOT ’reset’ the interest rate.
            StaticData_and_Mehtods s3 = new StaticData_and_Mehtods(2000);
            Console.WriteLine("Interest Rate is: {0}", StaticData_and_Mehtods.GetValue());
            Console.ReadLine();

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
